using System;
using System.Collections;
using System.Data;


namespace JPS.Controladores
{
    public class Sorteo : DBAccess.ErrorHandler
    {
        private Modelos.Sorteo oSorteo;

        public Sorteo()
        {
            oSorteo = new Modelos.Sorteo();
        }
        public DataTable Select()
        {
            DataTable result = new DataTable();
            result = this.oSorteo.Select();
            if (this.oSorteo.isError)
            {
                this.isError = true;
                this.errorDescription = this.oSorteo.errorDescription;
            }
            return result;
        }


        public void Insert(DateTime pFechaHora, bool pActivo, string pDescripcion)
        {
            this.oSorteo = new Modelos.Sorteo(pFechaHora, pActivo, pDescripcion);
            this.oSorteo.Insert();
            if (this.oSorteo.isError)
            {
                this.isError = true;
                this.errorDescription = this.oSorteo.errorDescription;
            }
        }

        public void Update(int id, DateTime pFechaHora, bool pActivo, string pDescripcion)
        {
            this.oSorteo = new Modelos.Sorteo(pFechaHora, pActivo, pDescripcion);
            this.oSorteo.Update(id);
            if (this.oSorteo.isError)
            {
                this.isError = true;
                this.errorDescription = this.oSorteo.errorDescription;
            }
        }

        public void Delete(int id)
        {
            this.oSorteo.Delete(id);
            if (this.oSorteo.isError)
            {
                this.isError = true;
                this.errorDescription = this.oSorteo.errorDescription;
            }
        }

        public DataTable SelecAll()
        {
            DataTable result = new DataTable();
            result = this.oSorteo.selectAll();
            if (this.oSorteo.isError)
            {
                this.isError = true;
                this.errorDescription = this.oSorteo.errorDescription;
            }
            return result;
        }
        public ArrayList SelectPrueba()
        {
            DataTable result = new DataTable();
            ArrayList oList = new ArrayList();
            result = this.oSorteo.selectAll();
            if (result.Rows.Count > 0)
            {
                for (int j = 0; j < result.Rows.Count; j++)
                {
                    DataRow row = result.Rows[j];
                    oSorteo = new Modelos.Sorteo();
                    oSorteo.id = int.Parse(row["id_sorteo"].ToString());
                    oSorteo.fecha_hora = DateTime.Parse(row["fecha_hora"].ToString());
                    oSorteo.activo = bool.Parse(row["activo"].ToString());
                    oSorteo.descripcion = row["descripcion"].ToString();
                    oList.Add(oSorteo);
                }
            }
            if (this.oSorteo.isError)
            {
                this.isError = true;
                this.errorDescription = this.oSorteo.errorDescription;
            }
            return oList;
        }

        public Modelos.Sorteo SelectInactive(int idSorteo)
        {
            DataTable result = new DataTable();
            result = this.oSorteo.selectInactive(idSorteo);
            if (result.Rows.Count > 0)
            {
                    DataRow row = result.Rows[0];
                    oSorteo = new Modelos.Sorteo();
                    oSorteo.id = int.Parse(row["id_sorteo"].ToString());
                    oSorteo.fecha_hora = DateTime.Parse(row["fecha_hora"].ToString());
                    oSorteo.activo = bool.Parse(row["activo"].ToString());
                    oSorteo.descripcion = row["descripcion"].ToString();
            }
            else
            {
                oSorteo = new Modelos.Sorteo();
                oSorteo.id = -1;
            }
            if (this.oSorteo.isError)
            {
                this.isError = true;
                this.errorDescription = this.oSorteo.errorDescription;
            }
            return oSorteo;
        }
    }
}

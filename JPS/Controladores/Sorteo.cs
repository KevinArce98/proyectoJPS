using System;
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
        public DataTable SelectInactive()
        {
            DataTable result = new DataTable();
            result = this.oSorteo.selectInactive();
            if (this.oSorteo.isError)
            {
                this.isError = true;
                this.errorDescription = this.oSorteo.errorDescription;
            }
            return result;
        }
    }
}

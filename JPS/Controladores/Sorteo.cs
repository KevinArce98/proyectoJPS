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
        public DataTable Select(DateTime pFechaHora, char pActivo, string pDescripcion)
        {
            DataTable result = new DataTable();
            result = this.oSorteo.Select(pFechaHora, pActivo, pDescripcion);
            if (this.oSorteo.isError)
            {
                this.isError = true;
                this.errorDescription = this.oSorteo.errorDescription;
            }
            return result;
        }


        public void Insert(DateTime pFechaHora, char pActivo, string pDescripcion)
        {
            this.oSorteo = new Modelos.Sorteo(pFechaHora, pActivo, pDescripcion);
            this.oSorteo.Insert();
            if (this.oSorteo.isError)
            {
                this.isError = true;
                this.errorDescription = this.oSorteo.errorDescription;
            }
        }

        public void Update(int id, DateTime pFechaHora, char pActivo, string pDescripcion)
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
    }
}

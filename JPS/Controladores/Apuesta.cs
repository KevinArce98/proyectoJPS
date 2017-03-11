using System.Data;

namespace JPS.Controladores
{
    public class Apuesta : DBAccess.ErrorHandler
    {
        private Modelos.Apuesta oApuesta;
        public Apuesta()
        {
            oApuesta = new Modelos.Apuesta();
        }
        public DataTable SelectTable()
        {
            DataTable result = new DataTable();
            result = this.oApuesta.SelectTable();
            if (this.oApuesta.isError)
            {
                this.isError = true;
                this.errorDescription = this.oApuesta.errorDescription;
            }
            return result;
        }


        public void Insert(Modelos.Usuario pUsuario, Modelos.Sorteo pSorteo, int pNumero, double pMonto)
        {
            this.oApuesta = new Modelos.Apuesta(pUsuario, pSorteo, pNumero, pMonto);
            this.oApuesta.Insert();
            if (this.oApuesta.isError)
            {
                this.isError = true;
                this.errorDescription = this.oApuesta.errorDescription;
            }
        }

        public void Update(int id, Modelos.Usuario pUsuario, Modelos.Sorteo pSorteo, int pNumero, double pMonto)
        {
            this.oApuesta = new Modelos.Apuesta(pUsuario, pSorteo, pNumero, pMonto);
            this.oApuesta.Update(id);
            if (this.oApuesta.isError)
            {
                this.isError = true;
                this.errorDescription = this.oApuesta.errorDescription;
            }
        }

        public void Delete(int id)
        {
            this.oApuesta.Delete(id);
            if (this.oApuesta.isError)
            {
                this.isError = true;
                this.errorDescription = this.oApuesta.errorDescription;
            }
        }
    }
}

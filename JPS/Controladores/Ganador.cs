using System.Data;

namespace JPS.Controladores
{
    public class Ganador : DBAccess.ErrorHandler
    {
        private Modelos.Ganador oGanador;

        public Ganador()
        {
            this.oGanador = new Modelos.Ganador();
        }
        public DataTable Select(Modelos.Sorteo pSorteo)
        {
            DataTable result = new DataTable();
            result = this.oGanador.Select(pSorteo);
            if (this.oGanador.isError)
            {
                this.isError = true;
                this.errorDescription = this.oGanador.errorDescription;
            }
            return result;
        }


        public void Insert(int pPrimero, int pSegundo, int pTercero, Modelos.Sorteo pSorteo)
        {
            this.oGanador = new Modelos.Ganador(pPrimero, pSegundo, pTercero, pSorteo);
            this.oGanador.Insert();
            if (this.oGanador.isError)
            {
                this.isError = true;
                this.errorDescription = this.oGanador.errorDescription;
            }
        }

        public void Update(int id, int pPrimero, int pSegundo, int pTercero, Modelos.Sorteo pSorteo)
        {
            this.oGanador = new Modelos.Ganador(pPrimero, pSegundo, pTercero, pSorteo);
            this.oGanador.Update(id);
            if (this.oGanador.isError)
            {
                this.isError = true;
                this.errorDescription = this.oGanador.errorDescription;
            }
        }

        public void Delete(int id)
        {
            this.oGanador.Delete(id);
            if (this.oGanador.isError)
            {
                this.isError = true;
                this.errorDescription = this.oGanador.errorDescription;
            }
        }
    }
}

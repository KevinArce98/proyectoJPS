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
        public Modelos.Ganador Select(int idSorteo)
        {
            DataTable result = new DataTable();
            result = this.oGanador.Select(idSorteo);
            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                this.oGanador.id = int.Parse(row["id_favorecido"].ToString());
                this.oGanador.primerNumero = int.Parse(row["primer_numero"].ToString());
                this.oGanador.segundoNumero = int.Parse(row["segundo_numero"].ToString());
                this.oGanador.tercerNumero = int.Parse(row["tercer_numero"].ToString());
                this.oGanador.oSorteo.id = int.Parse(row["id_sorteo"].ToString());
            }
            else
            {
                this.oGanador.id = -1;
            }
            if (this.oGanador.isError)
            {
                this.isError = true;
                this.errorDescription = this.oGanador.errorDescription;
            }
            return oGanador;
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

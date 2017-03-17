using System.Collections;
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
        public Modelos.Apuesta Select(int idUsuario, int idSorteo, int numero)
        {
            DataTable result = new DataTable();
            result = this.oApuesta.Select(idUsuario, idSorteo, numero);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                this.oApuesta.id = int.Parse(row["id_apuesta"].ToString());
                this.oApuesta.oUsuario.id = int.Parse(row["id_usuario"].ToString());
                this.oApuesta.oSorteo.id = int.Parse(row["id_sorteo"].ToString());
                this.oApuesta.numero = int.Parse(row["numero"].ToString());
                this.oApuesta.monto = double.Parse(row["monto"].ToString());
            }
            else
            {
                this.oApuesta.id = -1;
            }
            if (this.oApuesta.isError)
            {
                this.isError = true;
                this.errorDescription = this.oApuesta.errorDescription;
            }
            return oApuesta;
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
        public ArrayList SelectPay(int num1, int num2, int num3, int idSorteo)
        {
            ArrayList oList = new ArrayList();
            oList = this.oApuesta.SelectPay(num1, num2, num3, idSorteo);

            if (this.oApuesta.isError)
            {
                this.isError = true;
                this.errorDescription = this.oApuesta.errorDescription;
            }
            return oList;
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

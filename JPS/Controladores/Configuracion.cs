using System.Data;

namespace JPS.Controladores
{
    public class Configuracion : DBAccess.ErrorHandler
    {
        private Modelos.Configuracion oConfig;

        public Configuracion()
        {
            this.oConfig = new Modelos.Configuracion();
        }
        public double Select()
        {
            double monto = -1;
            DataTable result = new DataTable();
            result = this.oConfig.Select();
            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                monto = double.Parse(row["monto_casa"].ToString());
            }
            if (this.oConfig.isError)
            {
                this.isError = true;
                this.errorDescription = this.oConfig.errorDescription;
            }
            return monto;
        }


        public void Insert(double pMonto)
        {
            this.oConfig = new Modelos.Configuracion(pMonto);
            this.oConfig.Insert();
            if (this.oConfig.isError)
            {
                this.isError = true;
                this.errorDescription = this.oConfig.errorDescription;
            }
        }

        public void Update(double pMonto)
        {
            this.oConfig = new Modelos.Configuracion(pMonto);
            this.oConfig.Update();
            if (this.oConfig.isError)
            {
                this.isError = true;
                this.errorDescription = this.oConfig.errorDescription;
            }
        }

        public void Delete()
        {
            this.oConfig.Delete();
            if (this.oConfig.isError)
            {
                this.isError = true;
                this.errorDescription = this.oConfig.errorDescription;
            }
        }
    }
}

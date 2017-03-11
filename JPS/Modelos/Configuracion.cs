using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JPS.Modelos
{
   public class Configuracion : DBAccess.ErrorHandler
    {
        public double monto { get; set; }

        public Configuracion(double monto)
        {
            this.monto = monto;
        }
        public Configuracion()
        {

        }

        public DataTable Select()
        {
            string sql = "SELECT monto_casa FROM configuracion;";
            DataTable result = Program.da.SqlQuery(sql, new Dictionary<string,object>());
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
            }
            return result;
        }

        public void Insert()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("monto_casa", this.monto);

            DataTable result = Program.da.SqlQuery("INSERT INTO configuracion(monto_casa) VALUES (@monto_casa);", parametros);
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
                return;
            }
        }

        public void Delete()
        {
            Program.da.SqlStatement("delete from configuracion", new Dictionary<string, object>());
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
                return;
            }
        }

        public void Update(int id)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("monto_casa", this.monto);
          
            Program.da.SqlStatement("UPDATE configuracion SET monto_casa=@monto_casa;", parametros);
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
                return;
            }

        }
}

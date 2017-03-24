using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBAccess;
using System.Data;

namespace JPS.Modelos
{
    class Verificacion : ErrorHandler
    {
        public double Monto1 { get; set; }
        public double Monto2 { get; set; }
        public double Monto3 { get; set; }
        public int numero { get; set; }
        public double MontoNormal { get; set; }

        public DataTable Select()
        {
            string sql = "SELECT(monto * 60) as primero, (monto * 10) as segundo, (monto * 5) as tercero, * "
                +"FROM apuestas ORDER BY monto DESC LIMIT 3";

            DataTable result = Program.da.SqlQuery(sql, new Dictionary<string, object>());
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
            }
            return result;
        }

        
    }
}

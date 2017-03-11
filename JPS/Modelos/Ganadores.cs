using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JPS.Modelos
{
    public class Ganadores : DBAccess.ErrorHandler
    {
        public int id { get; set; }
        public int primerNumero { get; set; }
        public int segundoNumero { get; set; }
        public int tercerNumero { get; set; }
        public Sorteo oSorteo { get; set; }

        public Ganadores(int pPrimero, int pSegundo, int pTercero, Sorteo pSorteo)
        {
            this.primerNumero = pPrimero;
            this.segundoNumero = pSegundo;
            this.tercerNumero = pTercero;
            this.oSorteo = pSorteo;
        }
        public Ganadores()
        {

        }
        public DataTable Select(Sorteo pSorteo)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            StringBuilder sql_builder = new StringBuilder();

            if (pSorteo != null)
            {
                sql_builder.Append("id_sorteo == @id_sorteo ");
                parametros.Add("id_sorteo", string.Format("%{0}%", pSorteo.id));
            }

            string sql = "select * from favorecidos ";
            if (parametros.Count > 0)
            {

                sql += "where " + sql_builder.ToString();
            }

            DataTable result = Program.da.SqlQuery(sql, parametros);
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
            parametros.Add("primer_numero", this.primerNumero);
            parametros.Add("segundo_numero", this.segundoNumero);
            parametros.Add("tercer_numero", this.tercerNumero);
            parametros.Add("id_sorteo", this.oSorteo.id);

            DataTable result = Program.da.SqlQuery("insert into favorecidos (primer_numero, segundo_numero, tercer_numero, id_sorteo) "
                + "values (@primer_numero, @segundo_numero, @tercer_numero, @id_sorteo) returning id_favorecido;", parametros);
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
                return;
            }
            if (result.Rows.Count > 0)
            {
                this.id = Convert.ToInt32(result.Rows[0]["id_favorecido"]);
            }
        }

        public void Delete(int id)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id_favorecido", id);
            Program.da.SqlStatement("delete from favorecidos where id_favorecido = @id_favorecido", parametros);
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
            parametros.Add("primer_numero", this.primerNumero);
            parametros.Add("segundo_numero", this.segundoNumero);
            parametros.Add("tercer_numero", this.tercerNumero);
            parametros.Add("id_sorteo", this.oSorteo.id);
            parametros.Add("id_favorecido", id);
            Program.da.SqlStatement("update favorecidos set primer_numero= @primer_numero, segundo_numero=@segundo_numero, "
                +"tercer_numero=@tercer_numero, id_sorteo=@id_sorteo "
                + "where id_favorecido = @id_favorecido", parametros);
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
                return;
            }
        }

    }
}

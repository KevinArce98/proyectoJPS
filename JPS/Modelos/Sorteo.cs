using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JPS.Modelos
{
    public class Sorteo : DBAccess.ErrorHandler
    {
        public int id { get; set; }
        public DateTime fecha_hora { get; set; }
        public char activo { get; set; }
        public string descripcion { get; set; }

        public Sorteo(DateTime pFechaHora, char pActivo, string pDescripcion)
        {
            this.fecha_hora = pFechaHora;
            this.activo = pActivo;
            this.descripcion = pDescripcion;
        }
        public Sorteo()
        {

        }

        public override string ToString()
        {
            return this.descripcion;
        }

        public DataTable Select(DateTime pFechaHora, char pActivo, string pDescripcion)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            StringBuilder sql_builder = new StringBuilder();

            if (pFechaHora != null)
            {
                sql_builder.Append("fecha_hora == @fecha_hora ");
                parametros.Add("fecha_hora", pFechaHora);
            }

            if (pActivo != ' ')
            {
                if (parametros.Count > 0)
                {
                    sql_builder.Append(" and ");
                }
                sql_builder.Append("activo ilike @activo ");
                parametros.Add("activo", string.Format("%{0}%", pActivo));
            }


            if (!string.IsNullOrEmpty(pDescripcion))
            {
                if (parametros.Count > 0)
                {
                    sql_builder.Append(" and ");
                }
                sql_builder.Append("descripcion ilike @descripcion ");
                parametros.Add("descripcion", string.Format("%{0}%", pDescripcion));
            }

            string sql = "select * from sorteos ";
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

        public DataTable selectAll()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            string sql = "select * from sorteos ";
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
            parametros.Add("fecha_hora", this.fecha_hora);
            parametros.Add("activo", this.activo);
            parametros.Add("descripcion", this.descripcion);
 

            DataTable result = Program.da.SqlQuery("insert into sorteos (fecha_hora, activo, descripcion) "
                + "values (@fecha_hora, @activo, @descripcion) returning id_sorteo;", parametros);
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
                return;
            }
            if (result.Rows.Count > 0)
            {
                this.id = Convert.ToInt32(result.Rows[0]["id_sorteo"]);
            }
        }

        public void Delete(int id)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id", id);
            Program.da.SqlStatement("delete from sorteos where id_sorteo = @id", parametros);
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
            parametros.Add("fecha_hora", this.fecha_hora);
            parametros.Add("activo", this.activo);
            parametros.Add("descripcion", this.descripcion);
            parametros.Add("id", id);
            Program.da.SqlStatement("update sorteos set fecha_hora= @fecha_hora, activo=@activo, descripcion=@descripcion "
                + "where id_sorteo = @id", parametros);
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
                return;
            }
        }
    }
}

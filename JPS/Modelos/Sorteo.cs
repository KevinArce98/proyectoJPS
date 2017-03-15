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
        public bool activo { get; set; }
        public string descripcion { get; set; }

        public Sorteo(DateTime pFechaHora, bool pActivo, string pDescripcion)
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

        public DataTable Select()
        {
            string sql = "select * from sorteos ";
            DataTable result = Program.da.SqlQuery(sql, new Dictionary<string, object>());
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
            string sql = "select * from sorteos where activo = TRUE AND fecha_hora >= now();";
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
        public string toString()
        {
            return id + " - " + descripcion;
        }
    }
}

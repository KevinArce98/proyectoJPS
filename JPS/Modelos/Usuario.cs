using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JPS.Modelos
{
    public class Usuario : DBAccess.ErrorHandler
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public char admin { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }

        public Usuario(string pNombre, string pApellido, char pAdmin, string pCorreo, string pClave)
        {
            this.nombre = pNombre;
            this.apellido = pApellido;
            this.admin = pAdmin;
            this.correo = pCorreo;
            this.clave = pClave;
        }
        public Usuario()
        {

        }

        public DataTable Select(string pNombre, string pApellido, string pCorreo)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            StringBuilder sql_builder = new StringBuilder();
            
            if (!string.IsNullOrEmpty(pNombre))
            {
                sql_builder.Append("nombre ilike @nombre ");
                parametros.Add("nombre", string.Format("%{0}%", pNombre));
            }

            if (!string.IsNullOrEmpty(pApellido))
            {
                if (parametros.Count > 0)
                {
                    sql_builder.Append(" and ");
                }
                sql_builder.Append("apellido ilike @apellido ");
                parametros.Add("apellido", string.Format("%{0}%", pApellido));
            }


            if (!string.IsNullOrEmpty(pCorreo))
            {
                if (parametros.Count > 0)
                {
                    sql_builder.Append(" and ");
                }
                sql_builder.Append("correo ilike @correo ");
                parametros.Add("correo", string.Format("%{0}%", pCorreo));
            }

            string sql = "select * from usuarios ";
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
            parametros.Add("nombre", this.nombre);
            parametros.Add("apellido", this.apellido);
            parametros.Add("admin", this.admin);
            parametros.Add("correo", this.correo);
            parametros.Add("clave", this.clave);

            DataTable result = Program.da.SqlQuery("insert into usuarios (nombre, apellido, admin, correo, clave) "
                + "values (@nombre, @apellido, @admin, @correo, @clave) returning id_usuario;", parametros);
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
                return;
            }
            if (result.Rows.Count > 0)
            {
                this.id = Convert.ToInt32(result.Rows[0]["id_usuario"]);
            }
        }

        public void Delete(int id)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id_usuario", id);
            Program.da.SqlStatement("delete from usuarios where id_usuario = @id_usuario", parametros);
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
            parametros.Add("nombre", this.nombre);
            parametros.Add("apellido", this.apellido);
            parametros.Add("admin", this.admin);
            parametros.Add("correo", this.correo);
            parametros.Add("clave", this.clave);
            parametros.Add("id_usuario", id);
            Program.da.SqlStatement("update usuarios set nombre= @nombre, apellido=@apellido, admin=@admin, correo=@correo, clave=@clave "
                + "where id_usuario = @id_usuario", parametros);
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
                return;
            }
        }
    }
}

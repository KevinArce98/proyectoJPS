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
        public bool admin { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }

        public Usuario(string pNombre, string pApellido, bool pAdmin, string pCorreo, string pClave)
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

        public DataTable Select()
        {
            string sql = "SELECT id_usuario, nombre, apellido, admin, correo FROM usuarios ";
            DataTable result = Program.da.SqlQuery(sql, new Dictionary<string, object>());
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
            }
            return result;
        }
        public DataTable Login(string pCorreo, string password)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("correo", pCorreo);
            parametros.Add("clave", password);

            string sql = "SELECT * FROM usuarios WHERE correo = @correo AND clave = @clave";
            DataTable result = Program.da.SqlQuery(sql, parametros);
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
            }
            return result;
        }
        public DataTable SelectCorreo(int id)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id_usuario", id);
            string sql = "SELECT correo FROM usuarios WHERE id_usuario = @id_usuario;";
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

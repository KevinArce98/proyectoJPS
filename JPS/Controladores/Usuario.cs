using System.Collections;
using System.Data;

namespace JPS.Controladores
{
    public class Usuario : DBAccess.ErrorHandler
    {
        private Modelos.Usuario oUsuario;

        public Usuario()
        {
            oUsuario = new Modelos.Usuario();
        }
        public DataTable Select()
        {
            DataTable result = new DataTable();
            result = this.oUsuario.Select();
            if (this.oUsuario.isError)
            {
                this.isError = true;
                this.errorDescription = this.oUsuario.errorDescription;
            }
            return result;
        }

        public Modelos.Usuario SelectLogin(string pCorreo, string password)
        {
            DataTable result = new DataTable();
            result = this.oUsuario.Login(pCorreo, password);
            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                this.oUsuario.id = int.Parse(row["id_usuario"].ToString());
                this.oUsuario.nombre = row["nombre"].ToString();
                this.oUsuario.apellido = row["apellido"].ToString();
                this.oUsuario.admin = bool.Parse(row["admin"].ToString());
                this.oUsuario.correo = row["correo"].ToString();
                this.oUsuario.clave = row["clave"].ToString();
            }else
            {
                this.oUsuario.id = -1;
            }

            if (this.oUsuario.isError)
            {
                this.isError = true;
                this.errorDescription = this.oUsuario.errorDescription;
            }
            return oUsuario;
        }

        public Modelos.Usuario SelectCorreo(int id)
        {
            ArrayList oListCorreos = new ArrayList();
            DataTable result = new DataTable();
            result = this.oUsuario.SelectCorreo(id);
            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                this.oUsuario.correo = row["correo"].ToString();
            }

            if (this.oUsuario.isError)
            {
                this.isError = true;
                this.errorDescription = this.oUsuario.errorDescription;
            }
            return oUsuario;
        }


        public void Insert(string pNombre, string pApellido, bool pAdmin, string pCorreo, string pClave)
        {
            this.oUsuario = new Modelos.Usuario(pNombre, pApellido, pAdmin, pCorreo, pClave);
            this.oUsuario.Insert();
            if (this.oUsuario.isError)
            {
                this.isError = true;
                this.errorDescription = this.oUsuario.errorDescription;
            }
        }

        public void Update(int id, string pNombre, string pApellido, bool pAdmin, string pCorreo, string pClave)
        {
            this.oUsuario = new Modelos.Usuario(pNombre, pApellido, pAdmin, pCorreo, pClave);
            this.oUsuario.Update(id);
            if (this.oUsuario.isError)
            {
                this.isError = true;
                this.errorDescription = this.oUsuario.errorDescription;
            }
        }

        public void Delete(int id)
        {
            this.oUsuario.Delete(id);
            if (this.oUsuario.isError)
            {
                this.isError = true;
                this.errorDescription = this.oUsuario.errorDescription;
            }
        }
    }
}

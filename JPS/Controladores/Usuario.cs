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
        public DataTable Select(string pNombre, string pApellido, string pCorreo)
        {
            DataTable result = new DataTable();
            result = this.oUsuario.Select(pNombre, pApellido, pCorreo);
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
                this.oUsuario.admin = char.Parse(row["admin"].ToString());
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


        public void Insert(string pNombre, string pApellido, char pAdmin, string pCorreo, string pClave)
        {
            this.oUsuario = new Modelos.Usuario(pNombre, pApellido, pAdmin, pCorreo, pClave);
            this.oUsuario.Insert();
            if (this.oUsuario.isError)
            {
                this.isError = true;
                this.errorDescription = this.oUsuario.errorDescription;
            }
        }

        public void Update(int id, string pNombre, string pApellido, char pAdmin, string pCorreo, string pClave)
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

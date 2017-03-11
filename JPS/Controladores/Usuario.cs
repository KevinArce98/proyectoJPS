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

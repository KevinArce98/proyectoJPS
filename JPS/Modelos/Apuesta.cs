using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JPS.Modelos
{
    public class Apuesta : DBAccess.ErrorHandler
    {
        public int id { get; set; }
        public Usuario oUsuario { get; set; }
        public Sorteo oSorteo { get; set; }
        public int numero { get; set; }
        public double monto { get; set; }

        public Apuesta(Usuario pUsuario, Sorteo pSorteo, int pNumero, double pMonto)
        {
            this.oUsuario = pUsuario;
            this.oSorteo = pSorteo;
            this.numero = pNumero;
            this.monto = pMonto;
        }
        public Apuesta()
        {
            oUsuario = new Usuario();
            oSorteo = new Sorteo();
        }
        public DataTable Select(int idUsuario, int idSorteo, int numero)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id_usuario", idUsuario);
            parametros.Add("id_sorteo", idSorteo);
            parametros.Add("numero", numero);
            string sql = "select * from apuestas where id_usuario = @id_usuario AND id_sorteo = @id_sorteo AND numero = @numero";
            DataTable result = Program.da.SqlQuery(sql, parametros);
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
            }
            return result;
        }
        public DataTable SelectTable()
        {
            string sql = "select ap.id_apuesta, ap.numero, ap.monto, so.descripcion AS sorteo, us.nombre, us.apellido " 
                +"from apuestas ap, sorteos so, usuarios us"
                +" where ap.id_usuario = us.id_usuario AND ap.id_sorteo = so.id_sorteo ORDER BY ap.id_apuesta ASC;";

            DataTable result = Program.da.SqlQuery(sql, new Dictionary<string, object>());
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
            }
            return result;
        }

        public DataTable SelectPredciccion(int idUsuario)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id_usuario", idUsuario);
            string sql = "select * from apuestas WHERE id_usuario = @id_usuario";

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
            parametros.Add("id_usuario", this.oUsuario.id);
            parametros.Add("id_sorteo", this.oSorteo.id);
            parametros.Add("numero", this.numero);
            parametros.Add("monto", this.monto);

            DataTable result = Program.da.SqlQuery("insert into apuestas (id_usuario, id_sorteo, numero, monto) "
                + "values (@id_usuario, @id_sorteo, @numero, @monto) returning id_apuesta;", parametros);
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
                return;
            }
            if (result.Rows.Count > 0)
            {
                this.id = Convert.ToInt32(result.Rows[0]["id_apuesta"]);
            }
        }

        public void Delete(int id)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id_apuesta", id);
            Program.da.SqlStatement("delete from apuestas where id_apuesta = @id_apuesta", parametros);
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
            parametros.Add("id_usuario", this.oUsuario.id);
            parametros.Add("id_sorteo", this.oSorteo.id);
            parametros.Add("numero", this.numero);
            parametros.Add("monto", this.monto);
            parametros.Add("id_apuesta", id);
            Program.da.SqlStatement("update apuestas set id_usuario= @id_usuario, id_sorteo=@id_sorteo, numero=@numero, monto=@monto "
                + "where id_apuesta = @id_apuesta", parametros);
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
                return;
            }
        }

    }
}

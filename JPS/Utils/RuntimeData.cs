
using JPS.Controladores;
using System;
using System.Collections;
using System.Data;

namespace JPS.Utils
{
   public class RuntimeData
    {
        public static Modelos.Usuario oUsuario { get; set; }
        public static ArrayList cargarComboSorteo()
        {
            ArrayList oList = new ArrayList();
            Modelos.Sorteo oSorteo;
            Sorteo oSorteoC = new Sorteo();
            DataTable temp = oSorteoC.SelecAll();

            for (int i = 0; i < temp.Rows.Count; i++)
            {
                oSorteo = new Modelos.Sorteo();
                DataRow row = temp.Rows[i];
                oSorteo.id = int.Parse(row["id_sorteo"].ToString());
                oSorteo.fecha_hora = DateTime.Parse(row["fecha_hora"].ToString());
                oSorteo.activo = bool.Parse(row["activo"].ToString());
                oSorteo.descripcion = row["descripcion"].ToString();
                oList.Add(oSorteo);
            }
            return oList;
        }
    }
}

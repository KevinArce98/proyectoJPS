using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPS.Controladores;
using System.Collections;

namespace JPS.Utils
{
    class PayBet
    {
        public static void pagar(int idSorteo)
        {
            Ganador oGanador = new Ganador();
            Apuesta oApuesta = new Apuesta();
           
            ArrayList oList = oApuesta.SelectPrediccion(idSorteo);
            for (int i = 0; i < oList.Count; i++)
            {
                if (true)
                {

                }
            }
            Modelos.Ganador oGanadorM = oGanador.Select(idSorteo);

        }

    }
}

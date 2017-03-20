using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPS.Controladores;
using System.Collections;

namespace JPS.Utils
{
    public class Bets
    {

        public static ArrayList mostrarGanadas(int idUsuario, int idSorteo)
        {
            Apuesta oApuesta = new Apuesta();
            ArrayList oListGanada = new ArrayList();
            ArrayList olist = oApuesta.SelectCalcula(idSorteo, idUsuario, -1);
            for (int i = 0; i < olist.Count; i++)
            {
                Modelos.Apuesta oApuestaM = (Modelos.Apuesta)olist[i];
                double monto = montoTotal(oApuestaM.numero, oApuestaM.monto, oApuestaM.oSorteo.id);
                if (monto != -1)
                {
                    oApuestaM.montoGanado = monto;
                    oListGanada.Add(oApuestaM);
                }
            }
            return oListGanada;

        }
        public static double calcularApuesta(int num, double monto, int sorteo)
        {
            Apuesta oApuesta = new Apuesta();
            double total = 0;
            Configuracion oConfig = new Configuracion();
            double casa = oConfig.Select();
            ArrayList olist = oApuesta.SelectCalcula(sorteo, -1, num);

            for (int i = 0; i < olist.Count; i++)
            {
                Modelos.Apuesta oApuestaM = (Modelos.Apuesta)olist[i];
                total += oApuestaM.monto * 60;
            }
            total += monto * 60;
            casa = casa - total;
            if (casa < 0)
            {
                monto = -1;
            }
            else {
                monto = 0;
            }
            return monto;
        }
        public static void enviarCorreo(int num1, int num2, int num3, int idSorteo)
        {
            MailHandler oEmail = new MailHandler();
            Apuesta oApuesta = new Apuesta();
            Usuario oUsuario = new Usuario();
            ArrayList olist = oApuesta.SelectPay(num1, num2, num3, idSorteo);
            for (int i = 0; i < olist.Count; i++)
            {
                Modelos.Apuesta oApuestaM = (Modelos.Apuesta)olist[i];
                double monto = montoTotal(oApuestaM.numero, oApuestaM.monto, oApuestaM.oSorteo.id);
                oEmail.sendEmail(oApuestaM.numero, monto,oUsuario.SelectCorreo(oApuestaM.oUsuario.id).correo);
            }
        }
        private static double montoTotal(int num, double monto, int sorteo)
        {
            double total = -1;
            Ganador oGanador = new Ganador();
            Modelos.Ganador oGanadorM = oGanador.Select(sorteo);
            if (num == oGanadorM.primerNumero)
            {
                total = monto * 60;
            }
            else if(num == oGanadorM.segundoNumero)
            {
                total = monto * 10;
            }
            else if (num == oGanadorM.tercerNumero)
            {
                total = monto * 5;
            }
            return total;
        }

    }
}

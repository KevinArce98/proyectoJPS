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
        public static void pagar()
        {

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
                oEmail.sendEmail(oApuestaM.numero, oUsuario.SelectCorreo(oApuestaM.oUsuario.id).correo);
            }
        }

    }
}

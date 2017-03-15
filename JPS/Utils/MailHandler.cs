﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;


namespace JPS.Utils
{
    class MailHandler
    {

        MailMessage mmsg;
        string emailTo;
        string subject;
        string body;
        MailAddress mailFrom;
        SmtpClient cliente;

        public MailHandler()
        {
            this.mmsg = new MailMessage();
            //EMAILTO PONE AL QUE LO VA A MANDAR
            this.emailTo = "aa-kevin@hotmail.com";
            this.subject = "Notificación JPS";
            this.body = "Usted ha salido favorecido para el número X";
            //MAILFROM DESDE QUE CORREO LO VA A MANDAR
            this.mailFrom = new MailAddress("wcarvajal17@gmail.com");
            this.cliente = new SmtpClient();
        }

        public void sendEmail()
        {

            this.mmsg.To.Add(this.emailTo);
            this.mmsg.Subject = this.subject;
            this.mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            //EL BCC ES COMO UNA COPIA ADJUNTA DEL CORREO.. ES ALGO DE LOS CORREOS EN SI
            this.mmsg.Bcc.Add("wcarvajal17@gmail.com");
            this.mmsg.Body = this.body;
            this.mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            this.mmsg.IsBodyHtml = true;
            this.mmsg.From = this.mailFrom;
            //AQUI EN CREDENTIALS PONE SUS CREDENCIALES DE SU CORREO POR SI QUIERE PROBARLO
            this.cliente.Credentials = new System.Net.NetworkCredential("wcarvajal17@gmail.com",
                                                                        "");
            //PUERTO DE GMAIL POR SI QUIERE PROBAR CON OTRO LO CAMBIA
            this.cliente.Port = 587;
            this.cliente.EnableSsl = true;
            //IGUAL EL HOST LO PUEDE CAMBIAR
            this.cliente.Host = "smtp.gmail.com";
         
            try
            {
                this.cliente.Send(mmsg);
                Console.WriteLine("Se ha enviado el correo");
            }
            catch (System.Net.Mail.SmtpException ex)
            {


                Console.WriteLine(ex.Message);
            }
        }

    }
}

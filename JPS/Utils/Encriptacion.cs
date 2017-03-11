using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPS.Utils
{
    public class Encriptacion
    {
        public static string encriptarClave(string pClave)
        {
            string encriptada = string.Empty;
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(pClave);
            encriptada = Convert.ToBase64String(encryted);
            return encriptada;
           
        }
    }
}

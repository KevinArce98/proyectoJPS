﻿using System.Collections;
using System.Data;

namespace JPS.Controladores
{
    public class Apuesta : DBAccess.ErrorHandler
    {
        private Modelos.Apuesta oApuesta;
        public Apuesta()
        {
            oApuesta = new Modelos.Apuesta();
        }
        
        public DataTable SelectTable()
        {
            DataTable result = new DataTable();
            result = this.oApuesta.SelectTable();
            if (this.oApuesta.isError)
            {
                this.isError = true;
                this.errorDescription = this.oApuesta.errorDescription;
            }
            return result;
        }
        public ArrayList SelectPay(int num1, int num2, int num3, int idSorteo)
        {
            ArrayList oList = new ArrayList();
            oList = this.oApuesta.SelectPay(num1, num2, num3, idSorteo);

            if (this.oApuesta.isError)
            {
                this.isError = true;
                this.errorDescription = this.oApuesta.errorDescription;
            }
            return oList;
        }

        public ArrayList SelectCalcula(int idSorteo, int idUsuario = -1, int num = -1)
        {
            DataTable result = new DataTable();
            ArrayList oList = new ArrayList();
            if (num == -1)
            {
                result = this.oApuesta.SelectGanadas(idUsuario, idSorteo);
            }
            else if (idUsuario == -1)
            {
                result = this.oApuesta.SelectCalcula(num, idSorteo);
            }
            if (result.Rows.Count > 0)
            {
                for (int j = 0; j < result.Rows.Count; j++)
                {
                    DataRow row = result.Rows[j];
                    oApuesta = new Modelos.Apuesta();
                    oApuesta.id = int.Parse(row["id_apuesta"].ToString());
                    oApuesta.oUsuario.id = int.Parse(row["id_usuario"].ToString());
                    oApuesta.oSorteo.id = int.Parse(row["id_sorteo"].ToString());
                    oApuesta.numero = int.Parse(row["numero"].ToString());
                    oApuesta.monto = double.Parse(row["monto"].ToString());
                    oList.Add(oApuesta);
                }
            }

            if (this.oApuesta.isError)
            {
                this.isError = true;
                this.errorDescription = this.oApuesta.errorDescription;
            }
            return oList;
        }

        public ArrayList SelectTotal()
        {
            DataTable result = new DataTable();
            ArrayList oList = new ArrayList();
            result = this.oApuesta.SelectTotal();
            if (result.Rows.Count > 0)
            {
                for (int j = 0; j < result.Rows.Count; j++)
                {
                    DataRow row = result.Rows[j];
                    oApuesta = new Modelos.Apuesta();
                    oApuesta.id = int.Parse(row["id_apuesta"].ToString());
                    oApuesta.oUsuario.id = int.Parse(row["id_usuario"].ToString());
                    oApuesta.oSorteo.id = int.Parse(row["id_sorteo"].ToString());
                    oApuesta.numero = int.Parse(row["numero"].ToString());
                    oApuesta.monto = double.Parse(row["monto"].ToString());
                    oList.Add(oApuesta);
                }
            }

            if (this.oApuesta.isError)
            {
                this.isError = true;
                this.errorDescription = this.oApuesta.errorDescription;
            }
            return oList;
        }

        public void Insert(Modelos.Usuario pUsuario, Modelos.Sorteo pSorteo, int pNumero, double pMonto)
        {
            this.oApuesta = new Modelos.Apuesta(pUsuario, pSorteo, pNumero, pMonto);
            this.oApuesta.Insert();
            if (this.oApuesta.isError)
            {
                this.isError = true;
                this.errorDescription = this.oApuesta.errorDescription;
            }
        }

        public void Update(int id, Modelos.Usuario pUsuario, Modelos.Sorteo pSorteo, int pNumero, double pMonto)
        {
            this.oApuesta = new Modelos.Apuesta(pUsuario, pSorteo, pNumero, pMonto);
            this.oApuesta.Update(id);
            if (this.oApuesta.isError)
            {
                this.isError = true;
                this.errorDescription = this.oApuesta.errorDescription;
            }
        }

        public void Delete(int id)
        {
            this.oApuesta.Delete(id);
            if (this.oApuesta.isError)
            {
                this.isError = true;
                this.errorDescription = this.oApuesta.errorDescription;
            }
        }
    }
}

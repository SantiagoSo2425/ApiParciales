using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiServPub.Clases
{
    public class clsOpeUniversidad
    {
        #region Propiedades
        public Models.modUniversidad pModUni { get; set; }
        #endregion

        #region Metodos Privados
        public bool validar()
        {
            if (pModUni != null)
            {
                if (pModUni.Promedio < 0 || pModUni.Promedio > 5)
                {
                    pModUni.error = "El promedio debe estar entre 0 y 5";
                    return false;
                }

                return true;
            }
            else
            {
                pModUni = new Models.modUniversidad();
                pModUni.error = "El modelo no puede ser nulo";
                return false;
            }
        }

        private void liquidarMatricula()
        {
            float porcDescuento = 0;

            if (pModUni.EsPregrado)
            {
                pModUni.vrCredito = 50000;

                if (pModUni.Promedio >= 4.5f)
                {
                    pModUni.Creditos = 28;
                    porcDescuento = 25;
                }
                else if (pModUni.Promedio >= 4.0f)
                {
                    pModUni.Creditos = 25;
                    porcDescuento = 10;
                }
                else if (pModUni.Promedio > 3.5f)
                {
                    pModUni.Creditos = 20;
                }
                else if (pModUni.Promedio >= 2.5f)
                {
                    pModUni.Creditos = 15;
                }
                else
                {
                    pModUni.error = "No puede matricularse";
                    return;
                }
            }
            else
            {
                pModUni.vrCredito = 300000;

                if (pModUni.Promedio >= 4.5f)
                {
                    pModUni.Creditos = 20;
                    porcDescuento = 20;
                }
                else
                {
                    pModUni.Creditos = 10;
                }
            }

            pModUni.vrBruto = pModUni.Creditos * pModUni.vrCredito;
            pModUni.vrDescuento = pModUni.vrBruto * (porcDescuento / 100);
            pModUni.vrPagar = pModUni.vrBruto - pModUni.vrDescuento;
        }
        #endregion

        #region Metodos Publicos
        public void procesar()
        {
            if (!validar())
            {
                return;
            }
            else
            {
                liquidarMatricula();
            }
        }
        #endregion
    }
}

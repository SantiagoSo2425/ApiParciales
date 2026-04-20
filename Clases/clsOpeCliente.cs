using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiServPub.Clases
{
    public class clsOpeCliente
    {
        #region Propiedades
        public Models.modCliente pModCli { get; set; }
        #endregion

        #region Metodos Privados
        public bool validar()
        {
            if (pModCli != null)
            {
                if (pModCli.vrMontoAnual < 0)
                {
                    pModCli.error = "El monto anual no puede ser negativo";
                    return false;
                }

                if (string.IsNullOrWhiteSpace(pModCli.tipoCliente))
                {
                    pModCli.error = "El tipo de cliente es obligatorio";
                    return false;
                }

                string tipo = pModCli.tipoCliente.Trim().ToLower();
                if (tipo != "preferente" && tipo != "especial" && tipo != "ordinario")
                {
                    pModCli.error = "Tipo de cliente no valido";
                    return false;
                }

                return true;
            }
            else
            {
                pModCli = new Models.modCliente();
                pModCli.error = "El modelo no puede ser nulo";
                return false;
            }
        }

        private void hallarDescuento()
        {
            string tipo = pModCli.tipoCliente.Trim().ToLower();

            switch (tipo)
            {
                case "preferente":
                    if (pModCli.vrMontoAnual < 1500000)
                    {
                        pModCli.porcDescuento = 5;
                    }
                    else if (pModCli.vrMontoAnual <= 3500000)
                    {
                        pModCli.porcDescuento = 10;
                    }
                    else
                    {
                        pModCli.porcDescuento = 15;
                    }
                    break;

                case "especial":
                    if (pModCli.vrMontoAnual < 100000)
                    {
                        pModCli.porcDescuento = 3.5f;
                    }
                    else if (pModCli.vrMontoAnual <= 3000000)
                    {
                        pModCli.porcDescuento = 8.5f;
                    }
                    else
                    {
                        pModCli.porcDescuento = 12.5f;
                    }
                    break;

                case "ordinario":
                    if (pModCli.vrMontoAnual > 2000000)
                    {
                        pModCli.porcDescuento = 2.5f;
                    }
                    else
                    {
                        pModCli.porcDescuento = 0;
                    }
                    break;
            }

            pModCli.vrDescuento = pModCli.vrMontoAnual * (pModCli.porcDescuento / 100);
            pModCli.vrPagar = pModCli.vrMontoAnual - pModCli.vrDescuento;
        }
        #endregion

        #region Metodos Publicos
        public void liquidar()
        {
            if (!validar())
            {
                return;
            }
            else
            {
                hallarDescuento();
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiServPub.Clases
{
    public class clsOpeAlmacen
    {
        #region Propiedades
        public Models.modAlmacen pModAlm { get; set; }
        #endregion

        #region Metodos Privados
        public bool validar()
        {
            if (pModAlm != null)
            {
                if (pModAlm.vrCompra < 0)
                {
                    pModAlm.error = "El valor de la compra no puede ser negativo";
                    return false;
                }

                if (string.IsNullOrWhiteSpace(pModAlm.colorBolita))
                {
                    pModAlm.error = "El color de la bolita es obligatorio";
                    return false;
                }

                string color = pModAlm.colorBolita.Trim().ToLower();
                if (color != "blanca" && color != "verde" && color != "amarilla" && color != "azul" && color != "roja")
                {
                    pModAlm.error = "Color de bolita no valido";
                    return false;
                }

                return true;
            }
            else
            {
                pModAlm = new Models.modAlmacen();
                pModAlm.error = "El modelo no puede ser nulo";
                return false;
            }
        }

        private void hallarPago()
        {
            float porcDescuento = 0;
            string color = pModAlm.colorBolita.Trim().ToLower();

            switch (color)
            {
                case "blanca":
                    porcDescuento = 0;
                    break;
                case "verde":
                    porcDescuento = 10;
                    break;
                case "amarilla":
                    porcDescuento = 25;
                    break;
                case "azul":
                    porcDescuento = 50;
                    break;
                case "roja":
                    porcDescuento = 100;
                    break;
            }

            pModAlm.vrDescuento = pModAlm.vrCompra * (porcDescuento / 100);
            pModAlm.vrPagar = pModAlm.vrCompra - pModAlm.vrDescuento;
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
                hallarPago();
            }
        }
        #endregion
    }
}

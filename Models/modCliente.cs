using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiServPub.Models
{
    public class modCliente
    {
        #region Propiedades
        public float vrMontoAnual { get; set; }
        public string tipoCliente { get; set; }
        //salida
        public float porcDescuento { get; set; }
        public float vrDescuento { get; set; }
        public float vrPagar { get; set; }
        //Error
        public string error { get; set; }
        #endregion

        #region Constructor
        public modCliente()
        {
            vrMontoAnual = 0;
            tipoCliente = string.Empty;
            porcDescuento = 0;
            vrDescuento = 0;
            vrPagar = 0;
            error = string.Empty;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiServPub.Models
{
    public class modAlmacen
    {
        #region Propiedades
        public float vrCompra { get; set; }
        public string colorBolita { get; set; }
        //salida
        public float vrDescuento { get; set; }
        public float vrPagar { get; set; }
        //Error
        public string error { get; set; }
        #endregion

        #region Constructor
        public modAlmacen()
        {
            vrCompra = 0;
            colorBolita = string.Empty;
            vrDescuento = 0;
            vrPagar = 0;
            error = string.Empty;
        }
        #endregion
    }
}

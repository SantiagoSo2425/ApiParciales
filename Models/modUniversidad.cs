using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiServPub.Models
{
    public class modUniversidad
    {
        #region Propiedades
        public float Promedio { get; set; }
        public bool EsPregrado { get; set; }
        //salida
        public int Creditos { get; set; }
        public float vrCredito { get; set; }
        public float vrBruto { get; set; }
        public float vrDescuento { get; set; }
        public float vrPagar { get; set; }
        //Error
        public string error { get; set; }
        #endregion

        #region Constructor
        public modUniversidad()
        {
            Promedio = 0;
            EsPregrado = true;
            Creditos = 0;
            vrCredito = 0;
            vrBruto = 0;
            vrDescuento = 0;
            vrPagar = 0;
            error = string.Empty;
        }
        #endregion
    }
}

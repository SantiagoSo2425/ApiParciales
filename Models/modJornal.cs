using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiServPub.Models
{
    public class modJornal
    {
        #region Propiedades
        public float vrHora { get; set; }
        public int hrDiurnas { get; set; }
        public int hrNocturnas { get; set; }
        public bool domFestivo { get; set; }
        //salida
        public float vrDiurno { get; set; }
        public float vrNocturno { get; set; }
        public float vrJornal { get; set; }
        //Error
        public string error { get; set; }
        #endregion

        #region Constructor
        public modJornal()
        {
            vrHora = 0;
            hrDiurnas = 0;
            hrNocturnas = 0;
            domFestivo = false;
            vrDiurno = 0;
            vrNocturno = 0;
            vrJornal = 0;
            error = string.Empty;
        }
        #endregion
    }
}

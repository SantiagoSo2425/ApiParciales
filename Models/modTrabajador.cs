using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiServPub.Models
{
    public class modTrabajador
    {
        #region Propiedades
        public string Nombres { get; set; }
        public int HorasTrab { get; set; }
        public float vrHora { get; set; }
        //salida
        public float vrRecibido { get; set; }
        //Error
        public string error { get; set; }
        #endregion

        #region Constructor
        public modTrabajador()
        {
            Nombres = string.Empty;
            HorasTrab = 0;
            vrHora = 0;
            vrRecibido = 0;
            error = string.Empty;
        }
        #endregion
    }
}

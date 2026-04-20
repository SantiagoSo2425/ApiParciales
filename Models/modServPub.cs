using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiServPub.Models
{
    public class modServPub
    {
        #region Propiedades
        public int Estrato { get; set; }
        public int Kkw { get; set; }
        public int kM3 { get; set; }
        public int klTel { get; set; }
        public float vtDolar { get; set; }
        //salida  - Consumo
        public float vtKkw { get; set; }
        public float vtM3 { get; set; }
        public float vtTel { get; set; }
        // --------
        //salida - Valor total
        public float vrTEnergia { get; set; }
        public float vrTAgua { get; set; }
        public float vrTTel { get; set; }
        public float vrImpCons { get; set; }
        public float vtAPag { get; set; }
        //-----
        //Error
        public string error { get;  set; }


        #endregion
        #region Constructor
        public modServPub()
        {
            Estrato = 0;
            Kkw = 0;
            kM3 = 0;
            klTel = 0;
            vtDolar = 0;
            vtKkw = 0;
            vtM3 = 0;
            vtTel = 0;
            vrTEnergia = 0;
            vrTAgua = 0;
            vrTTel = 0;
            vrImpCons = 0;
            vtAPag = 0;
            error = string.Empty;
        }
        #endregion
    }
}
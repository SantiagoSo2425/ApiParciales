using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiServPub.Clases
{
    public class clsOpeServPub
    {
        #region Propiedades
        public Models.modServPub pModSP { get; set; }

        #endregion

        #region Metodos Privados
        public bool validar()
        {
            if (pModSP != null)
            {
                if (pModSP.Estrato < 1 || pModSP.Estrato > 6)
                {
                    pModSP.error = "El estrato debe ser entre 1 y 6";
                    return false;
                }

                if (pModSP.Kkw < 0)
                {
                    pModSP.error = "El consumo de energia no puede ser negativo";
                    return false;
                }
                if (pModSP.kM3 < 0)
                {
                    pModSP.error = "El consumo de agua no puede ser negativo";
                    return false;
                }
                if (pModSP.klTel < 0)
                {
                    pModSP.error = "El consumo de telefono no puede ser negativo";
                    return false;
                }
                if (pModSP.vtDolar < 0)
                {
                    pModSP.error = "El valor del dolar no puede ser negativo";
                    return false;
                }
                return true;
            }
            else
            {
                pModSP.error = "El modelo no puede ser nulo";
                return false;
            }

        }
        private void hallarConsumo()
        {
            float vrEnergia = 0;
            float vrAgua = 0;
            float vrTel = 0;
            switch (pModSP.Estrato)
            {
                case 1:
                    vrEnergia = 170;
                    vrAgua = 105;
                    vrTel = 5;
                    break;
                case 2:
                    vrEnergia = 170;
                    vrAgua = 105;
                    vrTel = 5;
                    break;
                case 3:
                    vrEnergia = 195;
                    vrAgua = 130;
                    vrTel = 10;
                    break;
                case 4:
                    vrEnergia = 195;
                    vrAgua = 130;
                    vrTel = 10;
                    break;
                case 5:
                    vrEnergia = 220;
                    vrAgua = 115;
                    vrTel = 15;
                    break;
                case 6:
                    vrEnergia = 220;
                    vrAgua = 115;
                    vrTel = 15;
                    break;
            }
            pModSP.vtKkw = (vrEnergia/100) * (pModSP.Kkw)*pModSP.vtDolar;
            pModSP.vtM3 = (vrAgua/100) * (pModSP.kM3)*pModSP.vtDolar;
            pModSP.vtTel = (vrTel/100) * (pModSP.klTel)*pModSP.vtDolar;
            pModSP.vrImpCons = (pModSP.vtKkw + pModSP.vtM3 + pModSP.vtTel) * 3/100;
        }
        private void hallarFijo()
        {
            float vrEnergia = 0;
            float vrAgua = 0;
            float vrTel = 0;
            switch (pModSP.Estrato)
            {
                case 1:
                    vrEnergia = 2.92f;
                    vrAgua = 2.15f;
                    vrTel = 1.81f;
                    break;
                case 2:
                    vrEnergia = 3.66f;
                    vrAgua = 2.91f;
                    vrTel = 2.37f;
                    break;
                case 3:
                    vrEnergia = 3.66f;
                    vrAgua = 2.91f;
                    vrTel = 2.37f;
                    break;
                case 4:
                    vrEnergia = 4.90f;
                    vrAgua = 4.34f;
                    vrTel = 3.68f;
                    break;
                case 5:
                    vrEnergia = 4.90f;
                    vrAgua = 4.34f;
                    vrTel = 3.68f;
                    break;
                case 6:
                    vrEnergia = 6.13f;
                    vrAgua = 5.35f;
                    vrTel = 4.79f;
                    break;
            }
            pModSP.vrTEnergia = (pModSP.Kkw ==0) ? 0 : vrEnergia * pModSP.vtDolar ;
            pModSP.vrTAgua = (pModSP.kM3 == 0) ? 0 : vrAgua * pModSP.vtDolar;
            pModSP.vrTTel = (pModSP.klTel == 0) ? 0 : vrTel * pModSP.vtDolar;
        }
        #endregion

            #region Metodos Metodos Publicos
            public void facturar()
        {
            if(!validar())      
            {
                return;
            }
            else
            {
                hallarConsumo();
                hallarFijo();
                pModSP.vtAPag = pModSP.vtKkw + pModSP.vtM3 + pModSP.vtTel + 
                    pModSP.vrTEnergia + pModSP.vrTAgua + pModSP.vrTTel + pModSP.vrImpCons;
            }
        }

            #endregion


        
    }
}
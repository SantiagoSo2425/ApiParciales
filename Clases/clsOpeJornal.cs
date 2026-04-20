using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiServPub.Clases
{
    public class clsOpeJornal
    {
        #region Propiedades
        public Models.modJornal pModJor { get; set; }
        #endregion

        #region Metodos Privados
        public bool validar()
        {
            if (pModJor != null)
            {
                if (pModJor.vrHora < 0)
                {
                    pModJor.error = "El valor de la hora no puede ser negativo";
                    return false;
                }

                if (pModJor.hrDiurnas < 0)
                {
                    pModJor.error = "Las horas diurnas no pueden ser negativas";
                    return false;
                }

                if (pModJor.hrNocturnas < 0)
                {
                    pModJor.error = "Las horas nocturnas no pueden ser negativas";
                    return false;
                }

                return true;
            }
            else
            {
                pModJor = new Models.modJornal();
                pModJor.error = "El modelo no puede ser nulo";
                return false;
            }
        }

        private void hallarJornal()
        {
            if (pModJor.domFestivo)
            {
                pModJor.vrDiurno = pModJor.hrDiurnas * pModJor.vrHora * 1.50f;
                pModJor.vrNocturno = pModJor.hrNocturnas * pModJor.vrHora * 1.75f;
            }
            else
            {
                pModJor.vrDiurno = pModJor.hrDiurnas * pModJor.vrHora;
                pModJor.vrNocturno = pModJor.hrNocturnas * pModJor.vrHora * 1.32f;
            }

            pModJor.vrJornal = pModJor.vrDiurno + pModJor.vrNocturno;
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
                hallarJornal();
            }
        }
        #endregion
    }
}

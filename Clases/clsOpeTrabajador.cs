using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiServPub.Clases
{
    public class clsOpeTrabajador
    {
        #region Propiedades
        public Models.modTrabajador pModTrab { get; set; }
        #endregion

        #region Metodos Privados
        public bool validar()
        {
            if (pModTrab != null)
            {
                if (string.IsNullOrWhiteSpace(pModTrab.Nombres))
                {
                    pModTrab.error = "El nombre del trabajador es obligatorio";
                    return false;
                }

                if (pModTrab.HorasTrab < 0)
                {
                    pModTrab.error = "Las horas trabajadas no pueden ser negativas";
                    return false;
                }

                if (pModTrab.vrHora < 0)
                {
                    pModTrab.error = "El valor de la hora no puede ser negativo";
                    return false;
                }

                return true;
            }
            else
            {
                pModTrab = new Models.modTrabajador();
                pModTrab.error = "El modelo no puede ser nulo";
                return false;
            }
        }

        private void hallarPago()
        {
            int hrNormales = 0;
            int hrExtras = 0;

            if (pModTrab.HorasTrab <= 40)
            {
                hrNormales = pModTrab.HorasTrab;
                pModTrab.vrRecibido = hrNormales * pModTrab.vrHora;
            }
            else
            {
                hrNormales = 40;
                hrExtras = pModTrab.HorasTrab - 40;

                if (hrExtras <= 8)
                {
                    pModTrab.vrRecibido = (hrNormales * pModTrab.vrHora) + (hrExtras * pModTrab.vrHora * 2);
                }
                else
                {
                    pModTrab.vrRecibido = (hrNormales * pModTrab.vrHora) + (8 * pModTrab.vrHora * 2) + ((hrExtras - 8) * pModTrab.vrHora * 3);
                }
            }
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

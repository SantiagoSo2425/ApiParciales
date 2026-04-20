using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using apiServPub.Clases;
using apiServPub.Models;

namespace apiServPub.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class sTrabajadorController : ApiController
    {
        // POST api/<controller>
        public modTrabajador Post([FromBody] modTrabajador objIn)
        {
            clsOpeTrabajador oOp = new clsOpeTrabajador();
            oOp.pModTrab = objIn;
            oOp.liquidar();
            return oOp.pModTrab;
        }
    }
}

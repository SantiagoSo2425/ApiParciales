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
    public class sUniversidadController : ApiController
    {
        // POST api/<controller>
        public modUniversidad Post([FromBody] modUniversidad objIn)
        {
            clsOpeUniversidad oOp = new clsOpeUniversidad();
            oOp.pModUni = objIn;
            oOp.procesar();
            return oOp.pModUni;
        }
    }
}

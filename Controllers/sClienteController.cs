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
    public class sClienteController : ApiController
    {
        // POST api/<controller>
        public modCliente Post([FromBody] modCliente objIn)
        {
            clsOpeCliente oOp = new clsOpeCliente();
            oOp.pModCli = objIn;
            oOp.liquidar();
            return oOp.pModCli;
        }
    }
}

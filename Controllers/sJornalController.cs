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
    public class sJornalController : ApiController
    {
        // POST api/<controller>
        public modJornal Post([FromBody] modJornal objIn)
        {
            clsOpeJornal oOp = new clsOpeJornal();
            oOp.pModJor = objIn;
            oOp.liquidar();
            return oOp.pModJor;
        }
    }
}

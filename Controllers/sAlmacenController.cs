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
    public class sAlmacenController : ApiController
    {
        // POST api/<controller>
        public modAlmacen Post([FromBody] modAlmacen objIn)
        {
            clsOpeAlmacen oOp = new clsOpeAlmacen();
            oOp.pModAlm = objIn;
            oOp.liquidar();
            return oOp.pModAlm;
        }
    }
}

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
    [EnableCors (origins: "*", headers: "*", methods: "*")]
    public class sSerPubController : ApiController
    {

        // POST api/<controller>
        public modServPub Post([FromBody] modServPub objIn)
        {
            clsOpeServPub oOp = new clsOpeServPub();
            oOp.pModSP = objIn;
            oOp.facturar();
            return oOp.pModSP;
        }


    }
}
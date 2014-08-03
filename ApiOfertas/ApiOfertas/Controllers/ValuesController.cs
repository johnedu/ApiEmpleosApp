using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiOfertas.Context;

namespace ApiOfertas.Controllers
{
    public class ValuesController : ApiController
    {
        db_ofertas_empleoEntities db = new db_ofertas_empleoEntities();

        // GET api/values
        public IEnumerable<OfertasEmpleo> Get()
        {
            return db.OfertasEmpleos.ToList();
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

using JSTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Nordia.Logic;

namespace JSTesting.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody]ReqestModel value)
        {
            if (value == null || string.IsNullOrEmpty(value.Format) || string.IsNullOrEmpty(value.TextToConvert))
            {
                var response = Request.CreateResponse<string>(HttpStatusCode.BadRequest, "Failed");
                return response;
            }
            else
            {
                FormatConvertor formatConvertor = new FormatConvertor();
                var response = Request.CreateResponse<string>(HttpStatusCode.Created, formatConvertor.Convert(value.Format, value.TextToConvert));
                return response;
            }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace WFMWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
   

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Log.Information("Log: Log.Information");
            Log.Warning("Log: Log.Warning");
            Log.Error("Log: Log.Error");
            Log.Fatal("Log: Log.Fatal");

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

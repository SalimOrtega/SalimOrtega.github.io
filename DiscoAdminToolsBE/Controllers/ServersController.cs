using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DiscoAdminToolsBE.Models;

namespace DiscoAdminToolsBE.Controllers
{
    [Route("serverstatusdashboard/[controller]")]
    public class ServersController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Server>> Get()
        {
            List<Server> serverList = new List<Server>();

            //
            Server dummy1 = new Server();
            dummy1.Name = "RENDISCOAPP02D";
            dummy1.Description = "Application server dos Discoverant development";
            dummy1.Type = "Application";
            dummy1.Procesor = "Xenon 2.4ghz";
            dummy1.RAMAmount = "16";
            dummy1.CurrentStatus = "Online";

            Server dummy2 = new Server();
            dummy2.Name = "RENDISCOAPP03D";
            dummy2.Description = "Application server dos Discoverant Sandbox";
            dummy2.Type = "Application";
            dummy2.Procesor = "Xenon 2.4ghz";
            dummy2.RAMAmount = "8";
            dummy2.CurrentStatus = "Online";

            serverList.Add(dummy1);
            serverList.Add(dummy2);
            //

            return serverList;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Server> Get(string name)
        {
            Server dummy1 = new Server();
            dummy1.Name = "RENDISCOAPP02D";
            dummy1.Description = "Application server dos Discoverant development";
            dummy1.Type = "Application";
            dummy1.Procesor = "Xenon 2.4ghz";
            dummy1.RAMAmount = "16";
            dummy1.CurrentStatus = "Online";

            return dummy1;
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

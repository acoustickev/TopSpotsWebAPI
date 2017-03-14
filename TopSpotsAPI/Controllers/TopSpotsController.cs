using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TopSpotsAPI.Models;
using Newtonsoft.Json;
using System.Collections;
using Newtonsoft.Json.Linq;
using System.Web;
using System.IO;

namespace TopSpotsAPI.Controllers
{
    public class TopSpotsController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET: api/TopSpots
        public IEnumerable<TopSpot> Get()
        {
            string fileName = HttpContext.Current.Server.MapPath("../App_Data/topspots.json");
            string json = File.ReadAllText(fileName);
            IEnumerable<TopSpot> topSpots = JsonConvert.DeserializeObject<IEnumerable<TopSpot>>(json);
            return topSpots;


        }

        // GET: api/TopSpots/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TopSpots
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TopSpots/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TopSpots/5
        public void Delete(int id)
        {
        }
    }
}

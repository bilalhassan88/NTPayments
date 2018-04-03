using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NTPayments.Interfaces;


namespace NTPayments.Controllers
{
    [Produces("application/json")]
    [Route("api/SOQuestionsManagement")]
    public class SOQuestionsManagementController : Controller
    {

        private IHttpResultGetter _ResultGetter;

        public SOQuestionsManagementController(IHttpResultGetter ResultGetter)
        {
            _ResultGetter = ResultGetter;
        }

        // GET: api/SOQuestionsManagement
        [HttpGet]
        public JsonResult Get()
        {
            {
                 return Json(JsonConvert.DeserializeObject(_ResultGetter.GetResult("https://api.stackexchange.com/2.2/questions?pagesize=50&order=desc&sort=creation&site=stackoverflow")));

            }

        }




        //// GET: api/SOQuestionsManagement/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/SOQuestionsManagement
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/SOQuestionsManagement/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

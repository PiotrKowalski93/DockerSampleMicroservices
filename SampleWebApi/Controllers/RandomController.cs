using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace SampleWebApi.Controllers
{
    [Route("[controller]")]
    public class RandomController : Controller
    {
        static Random _r = new Random();
        
        [HttpGet]
        public int Get()
        {
            return _r.Next(0, 9999 - 1);
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
            throw new NotImplementedException("Not Implemented.");
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException("Not Implemented.");
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException("Not Implemented.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ngLBDWebAPI.Models;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace ngLBDWebAPI.Controllers
{
    //[EnableCors(origins: "http://localhost:4200/#/about", headers: "*", methods: "*", exposedHeaders: "X-My-Header")]
    public class HomeController : ApiController
    {
        //public IEnumerable<Register> Get()
        //{
        //    List<Register> regList;
        //    using (var context = new RegistrationDBEntities())
        //    {
        //        regList = context.Registers.ToList();

        //    }
        //    return regList;

        //}

        public string Get()
        {
            return "h1";
        }

        public string  Get(string i)
        {
            return "h1" + i;
        }
    }
}

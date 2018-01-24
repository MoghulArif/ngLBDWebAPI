using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ngLBDWebAPI.Models;

namespace ngLBDWebAPI.Controllers
{
    public class HomeController : ApiController
    {
        public IEnumerable<Register> Get()
        {
            List<Register> regList;
            using (var context = new RegistrationDBEntities())
            {
                regList = context.Registers.ToList();
               
            }
            return regList;
            
        }

        public string  Get(int i)
        {
            return "h1";
        }
    }
}

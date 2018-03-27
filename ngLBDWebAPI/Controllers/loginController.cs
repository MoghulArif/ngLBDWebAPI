using ngLBDWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ngLBDWebAPI.Controllers
{
    public class loginController : ApiController
    {
        public int Post(loginModel loginModel)
        {
            int id;
            try
            {
                loginDB loginEF = new loginDB()
                {
                    userName = loginModel.userName,
                    pswrd = loginModel.password,
                };
                // will save data here in database;
                using (BGEnqiryEntities context = new BGEnqiryEntities())
                {
                    //context.homes.Add(loginEF);
                    context.loginDBs.Add(loginEF);
                    context.SaveChanges();

                    id = loginEF.id;

                   
                }
                return id;
            }
            catch(Exception ex)
            {
                return -1;
            }
            
        }

        public string Get(string s)
        {
            return s;
        }
    }
}
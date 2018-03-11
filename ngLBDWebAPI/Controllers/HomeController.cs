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
        /*
         
             
             */
        //    }
        //    return regList;

        //}

        public int Post(HomeModel homeModel)
        {
            int id;
            try
            {
                home hmeEF = new home()
                {
                    firstName = homeModel.firstName,
                    Mobile = homeModel.mobile,
                    Remarks = homeModel.remarks,
                    Email = homeModel.email,
                    locDubaiBusines = homeModel.locDubaiBusiness,
                    locDubaiSilicon = homeModel.locDubaiSilicon,
                    Budget400K700K = homeModel.budget400K700K,
                    Budget700K1000K = homeModel.budget700K1000K,
                    Budget1000K1250K = homeModel.budget1000K1250K,
                    Budget1250K1500K = homeModel.budget1250K1500K,
                    Studio = homeModel.studio,
                    OneBed = homeModel.oneBed,
                    TwoBed = homeModel.twoBed,
                    Retail = homeModel.retail,
                    Immed = homeModel.immed,
                    Months3to6 = homeModel.months3to6,
                    Months6to12 = homeModel.months6to12,
                    Months12to18 = homeModel.months12to18
                };
                // will save data here in database;
                using (BGEnqiryEntities context = new BGEnqiryEntities())
                {
                    context.homes.Add(hmeEF);
                    context.SaveChanges();

                    id = hmeEF.Id;

                   
                }
                return id;

            }
            catch(Exception ex)
            {
                return -1;
            }
            
        }

        public List<HomeModel> Get()
        {
            List<HomeModel> hm = new List<HomeModel>();
            string fn = "";
            string mob = "";

            using (BGEnqiryEntities ctx = new BGEnqiryEntities())
            {
                //hm = (from c in ctx.homes
                //             //join s in ctx.States
                //             //on c.StateId equals s.StateId
                //             //where c.Pincode == iPincode
                //             select new
                //             {
                //                 c.firstName,
                //                 c.lastName

                //             }).ToList<HomeModel>();

                var query = (from c in ctx.homes
                             select c);

                if(query != null)
                {
                    foreach(home h in query)
                    {
                        fn = h.firstName;
                        mob = h.Mobile;
                        hm.Add(new HomeModel() { firstName = fn, mobile = mob });
                    }
                }

                return hm;

             
            }

            //return "h1";
        }

        public HomeModel Get(int id) 
        {
            HomeModel hm = new HomeModel();
            string fn = "";
            string mob = "";

            using (BGEnqiryEntities ctx = new BGEnqiryEntities())
            {
                //hm = (from c in ctx.homes
                //             //join s in ctx.States
                //             //on c.StateId equals s.StateId
                //             //where c.Pincode == iPincode
                //             select new
                //             {
                //                 c.firstName,
                //                 c.lastName

                //             }).ToList<HomeModel>();

                var query = (from c in ctx.homes
                             where c.Id == id
                             select c);

                if (query != null)
                {
                    foreach (home h in query)
                    {
                        fn = h.firstName;
                        mob = h.Mobile;
                        hm = new HomeModel() { firstName = fn, mobile = mob };
                    }
                }

                return hm;
            }
        }
    }
}

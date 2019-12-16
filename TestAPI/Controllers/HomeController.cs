using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.Web.Http.Description;
using System.Web.Http;
using Entities;

namespace TestAPI.Controllers
{
    public class HomeController : ApiController
    {
        //DataTable dtCountries = new DataTable();

        //public ActionResult Index()
        //{
        //    ViewBag.Title = "Home Page";

        //    return View();
        //}
        

        [System.Web.Http.HttpPost]
        public int Sum(InputParam param)
        {
            return param.A + param.B + param.C;
        }

        [ResponseType(typeof(string))]
        public IHttpActionResult GetTest()
        {
            return Ok("HELLO");
        }

        //[HttpPost]
        //public string Countries()
        //{
        //    dtCountries.Columns.Add("CountryName");
        //    dtCountries.Columns.Add("Continent");

        //    dtCountries.Rows.Add("Armenia", "Europe");
        //    dtCountries.Rows.Add("USA", "North America");
        //    dtCountries.Rows.Add("Zanzibar", "Africa");

        //    //return Countries();
        //    return JsonConvert.SerializeObject(dtCountries);
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ITEC.Objects;
using Newtonsoft.Json;
using WebGrease;

namespace ITEC.Controllers
{
    public class HomeController : Controller
    {
        private const double MACEDONIAN_EMISSION = 5170;
        private static string _token = "baa20da23efec46c3435a893bf8f733b4daa0be0";
        private string _city = "Skopje";
        private string URL = "https://api.waqi.info/feed/skopje/?token=baa20da23efec46c3435a893bf8f733b4daa0be0";
        private string SearchURL = "https://api.waqi.info/search/?token=" + _token + "&keyword=";
        public ActionResult Index()
        {
            List<SearchData> r = new List<SearchData>();
            return View(r);
        }

        public ActionResult CalculateImpact(string fueltype, double consumption, double dailykm)
        {
            double result = Code.CarProcessing.Impact(fueltype, consumption, dailykm);
            result/=1000.0;
            result *= 365;
            double percentage = (result/MACEDONIAN_EMISSION)*100;
            ViewBag.Percentage = percentage;
            return View("Contribution");
        }
        public ActionResult Contribution()
        {
            return View();
        }

        public ActionResult Risks()
        {
            return View();
        }
        public ActionResult Search(string city)
        {
            List<SearchData> mylist;
            using (WebClient wc = new WebClient())
            {
                SearchURL += city;
                var json = wc.DownloadString(SearchURL);
                SearchResponse myResponse = JsonConvert.DeserializeObject<SearchResponse>(json);
                if (city.Equals("Veles-2"))
                {
                    ViewBag.Title = "Veles";
                }
                else if (city.Equals("Skopje"))
                {
                    ViewBag.Title = "Skopje";
                }
                else
                {
                    ViewBag.Title = "Tetovo";
                }
                mylist = Code.Queries.SortByPollution(myResponse);
            }
            return View("index",mylist);
        }


        public ActionResult Data()
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(URL);
                Response myResponse = JsonConvert.DeserializeObject<Response>(json);
                ViewBag.Message = json;
            }
            return View();
        }

    }
}
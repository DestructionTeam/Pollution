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
        private static string _token = "baa20da23efec46c3435a893bf8f733b4daa0be0";
        private string _city = "Skopje";
        private string URL = "https://api.waqi.info/feed/skopje/?token=baa20da23efec46c3435a893bf8f733b4daa0be0";
        private string SearchURL = "https://api.waqi.info/search/?token=" + _token + "&keyword=";
        public ActionResult Index()
        {
            List<SearchData> mylist;
            using (WebClient wc = new WebClient())
            {
                SearchURL += "Macedonia";
                var json = wc.DownloadString(SearchURL);
                SearchResponse myResponse = JsonConvert.DeserializeObject<SearchResponse>(json);
                mylist = Code.Queries.SortByPollution(myResponse);
            }
            return View(mylist);
        }
        [HttpGet]
        public ActionResult CalculateImpact(CarConsumption car)
        {
            double result = Code.CarProcessing.Impact(car);
            if (result < 130)
            {
                ViewBag.Result = "green";
                ViewBag.BoldMsg = "Your result is " + result + " g/km.";
                ViewBag.NormalMsg ="You are below the limit of 130 g/km and you are not a threat to the environment. Please continue using your car in the same way and also responsibly";
            }
            else
            {
                ViewBag.Result = "red";
                ViewBag.BoldMsg = "Your result is " + result + " g/km.";
                ViewBag.NormalMsg = "You are above the limit of 130g/km and you are a threat to the environment by causing pollution. You should put eco exhaust if you have not done so yet or use your car less.";
            }

            return View("Contribution",car);
        }
        public ActionResult Contribution()
        {
            
            return View(new CarConsumption());
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
    }
}
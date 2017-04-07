using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ITEC.Code;
using ITEC.Objects;

namespace ITEC.Controllers
{
    public class HomeController : Controller
    {
        private string _token = "baa20da23efec46c3435a893bf8f733b4daa0be0";
        private string _city = "Skopje";
        private const string URL = "https://api.waqi.info/feed/skopje/?token=baa20da23efec46c3435a893bf8f733b4daa0be0"; 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Data()
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(URL);
                Response myResponse = DataSerializer.GetResponse(json);

                ViewBag.Message = json.ToString();
            }
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
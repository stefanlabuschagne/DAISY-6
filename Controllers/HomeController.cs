using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAISY_6.Models.ViewModels;
using System.Net.Http;  // Client HTTP fir calling the API
using Newtonsoft.Json;
using System.Text;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DAISY_6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult DaisyCase()
        {

            ViewBag.Message = "Create Daisy Case";
            // Call The API To Update the DAISY DATBASE THROUGH THE Stored Proc

            return View();

        }

        [HttpPost]
        public ActionResult DaisyCase(DaisyCase model)
        {
            // We neeed to update the Database with the Model here.
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            ViewBag.Message = "Add Daisy Case";
            // Call The API To Update the DAISY DATBASE THROUGH THE Stored Proc



            // Map The model to the Target Object.
            // THE MODEL GETS PASSED TO THE API WITH ALL ITS MATCHING PROPERTIES AS IS :)
            // IT IS JUST JSON AFTERALL :)

            // GlobalVariables.WebApiClient.BaseAddress = new Uri("https://localhost:44305/");

            GlobalVariables.WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = GlobalVariables.WebApiClient.PostAsJsonAsync("api/SP/", model).Result;

            // var DaisyCaseNew 

            // HttpRequestMessage hrm = new HttpRequestMessage();

            // hc.BaseAddress = new Uri("/api/sp/AddCase");
            // var InsertRec = hc.PostAsync(model);
            // InsertRec.Wait();

            return View();

        }

            public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }


        //private static HttpContent CreateHttpContent(object content)
        //{
        //    HttpContent httpContent = null;

        //    if (content != null)
        //    {
        //        var ms = new MemoryStream();
        //        SerializeJsonIntoStream(content, ms);
        //        ms.Seek(0, SeekOrigin.Begin);
        //        httpContent = new StreamContent(ms);
        //        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        //    }

        //    return httpContent;
        //}

        //public static void SerializeJsonIntoStream(object value, Stream stream)
        //{
        //    using (var sw = new StreamWriter(stream, new UTF8Encoding(false), 1024, true))
        //    using (var jtw = new JsonTextWriter(sw) { Formatting = Formatting.None })
        //    {
        //        var js = new JsonSerializer();
        //        js.Serialize(jtw, value);
        //        jtw.Flush();
        //    }
        //}

    }
}
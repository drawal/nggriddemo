using JsonWithWebApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Hosting;
using System.Web.Http;
using WebDemo.Models;

namespace JsonWithWebApi.Controllers
{
    public class JsonController : ApiController
    {
        [Route("api/Applications")]
        public IEnumerable<Application> GetApplications()
        {
            return new List<Application>()
            {
                new Application()
            {
                Name = "SystemFlow",
                Language = "C#"
            },
            new Application()
            {
                Name = "CentralCodes",
                Language = "Javascript"
            },
            new Application()
            {
                Name = "DocMgmt",
                Language = "Angular"
            }
            };
        }

        [Route("api/DisplayItems")]
        public IEnumerable<DisplayItem> GetDisplayItems()
        {

            return LoadJsonData();

            //var jsonString = File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath("~/testData.json"));
            //StringContent sc = new StringContent(jsonString);
            //sc.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //HttpResponseMessage resp = new HttpResponseMessage();
            //resp.Content = sc;

            //return resp;

            //using (StreamReader reader = new StreamReader(VirtualPathProvider.OpenFile("~/testData.json")))
            //{
            //    StringContent sc = new StringContent(reader.ReadToEnd());
            //    sc.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //    HttpResponseMessage resp = new HttpResponseMessage();
            //    resp.Content = sc;

            //    return resp;
            //}
        }

        private List<DisplayItem> LoadJsonData()
        {
            var jsonString = File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath("~/testData.json"));
            JsonSerializer serializer = new JsonSerializer();

            TextReader tReader = File.OpenText(System.Web.HttpContext.Current.Server.MapPath("~/testData.json"));
            JsonReader jsonReader = new JsonTextReader(tReader);
            return serializer.Deserialize<List<DisplayItem>>(jsonReader);
        }


        [HttpGet]
        public Application Index()
        {
            return new Application()
            {
                Name = "Spectra",
                Language = "C#"
            };
        }

        //public string TestPost(NameValueCollection formData)
        //{
        //    return "Hello1";
        //}




        //public string Post(Application application)
        //{
        //    return (application != null)
        //        ? "Application received from client side : " + application.Name
        //        : "Application is null.";
        //}

        public string Post()
        {

            var request = Request.Content.ReadAsAsync(typeof(string));

            if (request.Result != null)
            {

            }

            var application = new Application();
            return (application != null)
                ? "Application received from client side : " + application.Name
                : "Application is null.";
        }
    }
}
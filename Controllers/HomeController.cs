using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PowerPointGenerator.Models;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;
using System.Configuration;

namespace PowerPointGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static string _key = ConfigurationManager.AppSettings.Get("Key");
        private static string _baseUri = "https://api.bing.microsoft.com/v7.0/images/search";
        private const string QUERY_PARAMETER = "?q="; 
        private const string MKT_PARAMETER = "&mkt="; 
        private static string _clientIdHeader = null;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(FormModel model)
        {
            List<ImageModel> images = new List<ImageModel>{};
            model.TitleToSearcList();
            string searchString = model.searchString;
            var client = new HttpClient();
            var queryString = QUERY_PARAMETER + Uri.EscapeDataString(searchString); 
            queryString += MKT_PARAMETER + "en-us";
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _key);
            HttpResponseMessage response = await client.GetAsync(_baseUri + queryString);
            var contentString = await response.Content.ReadAsStringAsync();
                Dictionary<string, object> searchResponse = JsonConvert.DeserializeObject<Dictionary<string, object>>(contentString);
            if(response.IsSuccessStatusCode)
            {
                model.PrintImages(searchResponse);
                images = model.ImagesFromAPI(searchResponse);
            }
            // var imageList = model.Images();
            ViewData["Images"] = images;
            return View("SelectImage", model);
        }

        [HttpGet]
        public IActionResult SelectImage()
        {
         return View();
        }
        [HttpPost]
        public JsonResult SelectImage(string ItemList, string[] dataList)
        {
            Console.WriteLine(ItemList);
            Console.WriteLine(dataList[0]);
            string[] arr = ItemList.Split(",");
            foreach(var id in arr) {
                var currentId = id;
            }
            return Json(ItemList);
            // List<ImageModel> images = model.ImageList;
            // Console.WriteLine("select image post " + model.ImageList.Count);
            // foreach(var img in model.ImageList)
            // {
                
            //     Console.WriteLine("is selected: => " + img.IsSelected);
            //     // if(img.IsSelected) 
            //     // {
            //     // model.AddToSelectedList(img);
            //     // Console.WriteLine("======== inside of select image controller");
            //     // }
            //     // else 
            //     // {
            //     // //  Console.WriteLine("//////// not selected////////");
            //     // }
            // }
            // return View( model);
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

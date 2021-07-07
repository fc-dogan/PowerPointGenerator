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

        public async Task<ActionResult> Index()
        {
            FormModel newModel = new FormModel();
            //add search string instead of the example below with instance of form model search string
            var searchString = "cat";
            var client = new HttpClient();
            var queryString = QUERY_PARAMETER + Uri.EscapeDataString(searchString); 
            queryString += MKT_PARAMETER + "en-us";
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _key);
            HttpResponseMessage response = await client.GetAsync(_baseUri + queryString);
            var contentString = await response.Content.ReadAsStringAsync();
                Dictionary<string, object> searchResponse = JsonConvert.DeserializeObject<Dictionary<string, object>>(contentString);
            if(response.IsSuccessStatusCode)
            {
                newModel.PrintImages(searchResponse);
            }

            return View();
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // public IActionResult Index()
        // {
        //     return View();
        // }

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

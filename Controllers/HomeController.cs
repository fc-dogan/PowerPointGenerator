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
using Microsoft.Office.Interop.PowerPoint;


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
        public async Task<ActionResult> Index(string title, string content)
        {
            List<ImageModel> images = new List<ImageModel>{};
            FormModel model = new FormModel(title, content);
            var client = new HttpClient();
            var queryString = QUERY_PARAMETER + Uri.EscapeDataString(model.searchString); 
            queryString += MKT_PARAMETER + "en-us";
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _key);
            HttpResponseMessage response = await client.GetAsync(_baseUri + queryString);
            var contentString = await response.Content.ReadAsStringAsync();
                Dictionary<string, object> searchResponse = JsonConvert.DeserializeObject<Dictionary<string, object>>(contentString);
            if(response.IsSuccessStatusCode)
            {
                images = model.ImagesFromAPI(searchResponse);
            }
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
            string[] PictureFile = dataList;
            Application pptApplication = new Application();
            Presentation pptpresentation = pptApplication.Presentations.Add(Microsoft.Office.Core.MsoTriState.msoTrue);
            for (int i = 0; i < PictureFile.Length; i++)
            {
                Microsoft.Office.Interop.PowerPoint.Slides slides;
                Microsoft.Office.Interop.PowerPoint._Slide slide;
                Microsoft.Office.Interop.PowerPoint.TextRange objText;

                Microsoft.Office.Interop.PowerPoint.CustomLayout custLayout = pptpresentation.SlideMaster.CustomLayouts[Microsoft.Office.Interop.PowerPoint.PpSlideLayout.ppLayoutText];
                slides = pptpresentation.Slides;
                slide = slides.AddSlide(i + 1, custLayout);

                objText = slide.Shapes[1].TextFrame.TextRange;
                objText.Text = FormModel.Title;
                objText.Font.Name = "Arial";
                objText.Font.Size = 32;

                Microsoft.Office.Interop.PowerPoint.Shape shape = slide.Shapes[2];
                slide.Shapes.AddPicture(PictureFile[i], 
                    Microsoft.Office.Core.MsoTriState.msoFalse,
                    Microsoft.Office.Core.MsoTriState.msoTrue,
                    shape.Left, shape.Top, shape.Width, shape.Height);

            }
            pptpresentation.SaveAs(@"C:\powerpoint\newslide.pptx", 
                Microsoft.Office.Interop.PowerPoint.PpSaveAsFileType.ppSaveAsDefault, 
                Microsoft.Office.Core.MsoTriState.msoTrue);

            return Json(ItemList);
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

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
    public class FormController : Controller
    {
        private static string _key = ConfigurationManager.AppSettings.Get("Key");
        private static string _baseUri = "https://api.bing.microsoft.com/v7.0/images/search";
        private const string QUERY_PARAMETER = "?q="; 
        private const string MKT_PARAMETER = "&mkt="; 
        private static string _clientIdHeader = null;

         public IActionResult Edit()
        {
            ViewBag.title = FormModel.Title;
            ViewBag.content = FormModel.Content;
            return View();
        }
        public async Task<ActionResult> SelectImage(string content, string[] boldedWords)
        {
            List<ImageModel> images = new List<ImageModel>{};
            FormModel.SetTheList(content, boldedWords);
            var searchString = FormModel.searchString;
            var client = new HttpClient();
            var queryString = QUERY_PARAMETER + Uri.EscapeDataString(searchString); 
            queryString += MKT_PARAMETER + "en-us";
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _key);
            HttpResponseMessage response = await client.GetAsync(_baseUri + queryString);
            var contentString = await response.Content.ReadAsStringAsync();
            Dictionary<string, object> searchResponse = JsonConvert.DeserializeObject<Dictionary<string, object>>(contentString);
            if(response.IsSuccessStatusCode)
            {
                images = FormModel.ImagesFromAPI(searchResponse);
            }
            ViewData["Images"] = images;
           
             return View();
        }
        public JsonResult CreatePowerPoint(string ItemList, string[] dataList)
        {
            string[] PictureFile = dataList;
            Application pptApplication = new Application();
            Presentation pptpresentation = pptApplication.Presentations.Add(Microsoft.Office.Core.MsoTriState.msoTrue);
           
            Microsoft.Office.Interop.PowerPoint.Slides slides;
            Microsoft.Office.Interop.PowerPoint._Slide slide;
            Microsoft.Office.Interop.PowerPoint.TextRange objText;
            Microsoft.Office.Interop.PowerPoint.TextRange contentText;

            Microsoft.Office.Interop.PowerPoint.CustomLayout custLayout = pptpresentation.SlideMaster.CustomLayouts[Microsoft.Office.Interop.PowerPoint.PpSlideLayout.ppLayoutText];
            slides = pptpresentation.Slides;
            slide = slides.AddSlide(1, custLayout);
                
            //add title
            objText = slide.Shapes[1].TextFrame.TextRange;
            objText.Text = FormModel.Title;
            objText.Font.Name = "Arial";
            objText.Font.Size = 32;

            contentText = slide.Shapes[2].TextFrame.TextRange;
            contentText.Text = FormModel.Content;
            contentText.Font.Name = "Arial";
            contentText.Font.Size = 20;
            
            Microsoft.Office.Interop.PowerPoint.Shape shape = slide.Shapes[2];
    
            slide.Shapes.AddPicture(PictureFile[0], 
                Microsoft.Office.Core.MsoTriState.msoFalse,
                Microsoft.Office.Core.MsoTriState.msoTrue,
                250, shape.Top+30 , 200, 200);

            slide.Shapes.AddPicture(PictureFile[1], 
                Microsoft.Office.Core.MsoTriState.msoFalse,
                Microsoft.Office.Core.MsoTriState.msoTrue,
                460, shape.Top+30, 200, 200);

            slide.Shapes.AddPicture(PictureFile[2], 
                Microsoft.Office.Core.MsoTriState.msoFalse,
                Microsoft.Office.Core.MsoTriState.msoTrue,
                670, shape.Top+30, 200, 200);

            pptpresentation.SaveAs(@"C:\powerpoint\newslide.pptx", 
                Microsoft.Office.Interop.PowerPoint.PpSaveAsFileType.ppSaveAsDefault, 
                Microsoft.Office.Core.MsoTriState.msoTrue);

            return Json(dataList);
        }
    }
}

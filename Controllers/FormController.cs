// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// using PowerPointGenerator.Models;
// using System.Net.Http.Headers;
// using System.Net.Http;
// using Newtonsoft.Json;
// using System.Configuration;
// using Microsoft.Office.Interop.PowerPoint;


// namespace PowerPointGenerator.Controllers
// {
//     public class FormController : Controller
//     {
//         private static string _key = ConfigurationManager.AppSettings.Get("Key");
//         private static string _baseUri = "https://api.bing.microsoft.com/v7.0/images/search";
//         private const string QUERY_PARAMETER = "?q="; 
//         private const string MKT_PARAMETER = "&mkt="; 
//         private static string _clientIdHeader = null;


//         [HttpPost] 
//         public ActionResult Form(string title, string content)
//         {
//             // FormModel model = new FormModel(title, content);
//             Console.WriteLine(title);
//             // if (chkAddon != null)
//             //     ViewBag.Addon = "Selected";
//             // else
//             //     ViewBag.Addon = "Not Selected";
 
//             return View("Index");
//         }

//         // [HttpPost]
//         // public async Task<ActionResult> Index(FormModel model)
//         // {
//         //     List<ImageModel> images = new List<ImageModel>{};
//         //     // model.TitleToSearcList();
//         //     string searchString = model.searchString;
//         //     var client = new HttpClient();
//         //     var queryString = QUERY_PARAMETER + Uri.EscapeDataString(searchString); 
//         //     queryString += MKT_PARAMETER + "en-us";
//         //     client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _key);
//         //     HttpResponseMessage response = await client.GetAsync(_baseUri + queryString);
//         //     var contentString = await response.Content.ReadAsStringAsync();
//         //         Dictionary<string, object> searchResponse = JsonConvert.DeserializeObject<Dictionary<string, object>>(contentString);
//         //     if(response.IsSuccessStatusCode)
//         //     {
//         //         model.PrintImages(searchResponse);
//         //         images = model.ImagesFromAPI(searchResponse);
//         //     }
//         //     // var imageList = model.Images();
//         //     ViewData["Images"] = images;
//         //     return View("SelectImage", model);
//         // }

//         [HttpGet]
//         public IActionResult SelectImage()
//         {
//          return View();
//         }
//         [HttpPost]
//         public JsonResult SelectImage(string ItemList, string[] dataList)
//         {
//             Console.WriteLine(ItemList);
//             Console.WriteLine(dataList[0]);
//             string[] PictureFile = dataList;
//             Application pptApplication = new Application();
//             Presentation pptpresentation = pptApplication.Presentations.Add(Microsoft.Office.Core.MsoTriState.msoTrue);
//             for (int i = 0; i < PictureFile.Length; i++)
//             {
//                 Microsoft.Office.Interop.PowerPoint.Slides slides;
//                 Microsoft.Office.Interop.PowerPoint._Slide slide;
//                 Microsoft.Office.Interop.PowerPoint.TextRange objText;

//                 Microsoft.Office.Interop.PowerPoint.CustomLayout custLayout = pptpresentation.SlideMaster.CustomLayouts[Microsoft.Office.Interop.PowerPoint.PpSlideLayout.ppLayoutText];
//                 slides = pptpresentation.Slides;
//                 slide = slides.AddSlide(i + 1, custLayout);

//                 objText = slide.Shapes[1].TextFrame.TextRange;
//                 objText.Text = FormModel.Title + i ;
//                 objText.Font.Name = "Arial";
//                 objText.Font.Size = 32;

//                 Microsoft.Office.Interop.PowerPoint.Shape shape = slide.Shapes[2];
//                 slide.Shapes.AddPicture(PictureFile[i], 
//                     Microsoft.Office.Core.MsoTriState.msoFalse,
//                     Microsoft.Office.Core.MsoTriState.msoTrue,
//                     shape.Left, shape.Top, shape.Width, shape.Height);

//             }
//             pptpresentation.SaveAs(@"C:\powerpoint\newslide.pptx", 
//                 Microsoft.Office.Interop.PowerPoint.PpSaveAsFileType.ppSaveAsDefault, 
//                 Microsoft.Office.Core.MsoTriState.msoTrue);


//             string[] arr = ItemList.Split(",");
//             foreach(var id in arr) {
//                 var currentId = id;
//             }
//             return Json(ItemList);
//             // List<ImageModel> images = model.ImageList;
//             // Console.WriteLine("select image post " + model.ImageList.Count);
//             // foreach(var img in model.ImageList)
//             // {
                
//             //     Console.WriteLine("is selected: => " + img.IsSelected);
//             //     // if(img.IsSelected) 
//             //     // {
//             //     // model.AddToSelectedList(img);
//             //     // Console.WriteLine("======== inside of select image controller");
//             //     // }
//             //     // else 
//             //     // {
//             //     // //  Console.WriteLine("//////// not selected////////");
//             //     // }
//             // }
//             // return View( model);
//         }


//     }
// }

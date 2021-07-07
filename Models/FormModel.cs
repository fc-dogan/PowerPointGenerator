using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Configuration;

namespace PowerPointGenerator.Models
{
  public class FormModel
  {
    public string Title { get; set; }
    public string Content { get; set; }
    public string searchString {get; set;}
    public List<string> SearchWords = new List<string> {};
    public List<ImageModel> ImageList = new List<ImageModel>{};

    public void TitleToSearcList()
    {
      // Title = title;
      char[] separators = new char[] { ' ', '.' };
      string[] subs = Title.Split(separators, StringSplitOptions.RemoveEmptyEntries);
      foreach (var sub in subs)
      {
        SearchWords.Add(sub);
      }
      searchString = string.Join(", ",SearchWords);
      Console.WriteLine(searchString);
    }

    public void PrintImages(Dictionary<string, object> response)
        {
            Console.WriteLine("The response contains the following images:\n");
            var images = response["value"] as Newtonsoft.Json.Linq.JToken;
            foreach (Newtonsoft.Json.Linq.JToken image in images)
            {
                Console.WriteLine("Thumbnail: " + image["thumbnailUrl"]);
                Console.WriteLine("Thumbnail size: {0} (w) x {1} (h) ", image["thumbnail"]["width"], image["thumbnail"]["height"]);
                Console.WriteLine("Original image: " + image["contentUrl"]);
                Console.WriteLine("Original image size: {0} (w) x {1} (h) ", image["width"], image["height"]);
                Console.WriteLine("Host: {0} ({1})", image["hostPageDomainFriendlyName"], image["hostPageDisplayUrl"]);
                Console.WriteLine();
            }
        }

      public void ImagesFromAPI(Dictionary<string, object> response)
        {
          var images = response["value"] as Newtonsoft.Json.Linq.JToken;
          foreach (Newtonsoft.Json.Linq.JToken image in images)
            {
              string thumbnailUrl = image["thumbnailUrl"].ToString();
              string imageUrl = image["contentUrl"].ToString();
              ImageModel newImage = new ImageModel(thumbnailUrl, imageUrl);
              ImageList.Add(newImage);
              // string img = image["thumbnailUrl"].ToString();
              // thumbnails.Add(img);
            }
        }


  }
}
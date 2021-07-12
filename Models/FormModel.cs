using System.ComponentModel.DataAnnotations.Schema;
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
    public static string Title { get; set; }
    public static string Content { get; set; }
    public static string searchString {get; set;}
    public static List<string> SearchWords = new List<string> {};
    public static List<ImageModel> ImageList = new List<ImageModel>{};

    public FormModel(string title, string content)
    {
      Title = title;
      Content = content;
    }
    public static void SetTheList(string content, string[] boldedWords)
    {
      TitleToSearcList(Title);
      BoldedWordsToList(boldedWords);
      SearchListToString();
    }
    public static void BoldedWordsToList(string[] boldedWords)
    {
      foreach (var item in boldedWords)
      {
        SearchWords.Add(item);
      }
    }
    public static void TitleToSearcList(string title)
    {
      char[] separators = new char[] { ' ', '.' };
      string[] subs = title.Split(separators, StringSplitOptions.RemoveEmptyEntries);
      foreach (var sub in subs)
      {
        SearchWords.Add(sub);
      }
    }

    public static void SearchListToString()
    {
      searchString = string.Join(", ",SearchWords);
    }

    private static List<string> ExtractFromBody(string body, string start, string end)
    {
      List<string> matched = new List<string>();
      int indexStart = 0;
      int indexEnd = 0;
      bool exit = false;
      while (!exit)
      {
        indexStart = body.IndexOf(start);
        if (indexStart != -1)
        {
          indexEnd = indexStart + body.Substring(indexStart).IndexOf(end);
          matched.Add(body.Substring(indexStart + start.Length, indexEnd - indexStart - start.Length));
          body = body.Substring(indexEnd + end.Length);
        }
        else
        {
          exit = true;
        }
      }
      return matched;
    }

    public static List<ImageModel> ImagesFromAPI(Dictionary<string, object> response)
    {
      var images = response["value"] as Newtonsoft.Json.Linq.JToken;
      foreach (Newtonsoft.Json.Linq.JToken image in images)
        {
          string thumbnailUrl = image["thumbnailUrl"].ToString();
          string imageUrl = image["contentUrl"].ToString();
          ImageModel newImage = new ImageModel(thumbnailUrl, imageUrl);
          ImageList.Add(newImage);
        }
        return ImageList;
    }

  }
}
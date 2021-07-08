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
  public class ImageModel
  {
    public string ThumbnailUrl {get; set;}
    public string ImageUrl { get; set; }
    public bool IsSelected { get; set; }
    public int Id {get; set;} 
     public static int CurrentId {get; set;} = 0;
    public static List<ImageModel> ImageList = new List<ImageModel>{};

    public ImageModel(string thumbnailUrl, string imageUrl)
    {
      ThumbnailUrl = thumbnailUrl;
      ImageUrl = imageUrl;
      IncrementId();
      Id = CurrentId;
      ImageList.Add(this);
    }
    public static void IncrementId()
    {
      CurrentId ++;
    }   

  }
}
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
    public bool IsSelected { get; set; } = false;
    // public static List<ImageModel> ImageList = new List<ImageModel>{};

    public ImageModel(string thumbnailUrl, string imageUrl)
    {
      ThumbnailUrl = thumbnailUrl;
      ImageUrl = imageUrl;
      // ImageList.Add(this);
    }

  }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiphyDotNet.Model.GiphyImage
{
    public class Looping
    {
        [JsonProperty("mp4")]
        public string Url { get; set; }
    }
}

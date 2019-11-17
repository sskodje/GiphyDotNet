using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiphyDotNet.Model.GiphyImage
{
    public class PreviewGif
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }
    }
}

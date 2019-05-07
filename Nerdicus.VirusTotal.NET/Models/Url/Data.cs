﻿using System;
using System.Collections.Generic;
using System.Text;
using Nerdicus.VirusTotalNET.Models.Base;
using Newtonsoft.Json;

namespace Nerdicus.VirusTotalNET.Models.Url
{
    public class Data : Base.Data
    {
        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("relationships")]
        public Relationships Relationships { get; set; }
    }

}

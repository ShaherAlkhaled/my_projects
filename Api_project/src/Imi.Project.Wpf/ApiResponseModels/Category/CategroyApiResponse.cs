﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.ApiResponseModels.Category
{
    public class CategroyApiResponse:BaseApiResponse
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

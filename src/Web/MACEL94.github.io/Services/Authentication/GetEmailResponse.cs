﻿using System.Text.Json.Serialization;

namespace MACEL94.github.io.Services.Authentication
{
    public class GetEmailResponse
    {
        [JsonPropertyName("elements")]
        public Element[]? Elements { get; set; }
    }
}
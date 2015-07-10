﻿using Newtonsoft.Json;

namespace KoenZomers.OneDrive.Api.Entities
{
    internal class OneDriveUploadSessionItemContainer
    {
        [JsonProperty("item", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public OneDriveUploadSessionItem Item { get; set; }
    }
}

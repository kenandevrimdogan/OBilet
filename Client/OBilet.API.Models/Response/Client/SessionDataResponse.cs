﻿using Newtonsoft.Json;

namespace OBilet.API.Models.Response.Client
{
    public class SessionDataResponse
    {
        [JsonProperty("session-id")]
        public string sessionid { get; set; }

        [JsonProperty("device-id")]
        public string deviceid { get; set; }
        public object affiliate { get; set; }

        [JsonProperty("device-type")]
        public int devicetype { get; set; }
        public object device { get; set; }

        [JsonProperty("ip-country")]
        public string ipcountry { get; set; }
    }
}

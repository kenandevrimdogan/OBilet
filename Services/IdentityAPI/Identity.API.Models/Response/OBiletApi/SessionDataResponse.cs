﻿namespace Identity.API.Models.Response.OBiletApi
{
    public class SessionDataResponse
    {
        public string sessionid { get; set; }

        public string deviceid { get; set; }
        public object affiliate { get; set; }

        public int devicetype { get; set; }
        public object device { get; set; }

        public string ipcountry { get; set; }
    }
}

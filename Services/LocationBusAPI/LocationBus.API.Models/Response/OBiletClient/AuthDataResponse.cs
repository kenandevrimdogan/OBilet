﻿namespace LocationBus.API.Models.Response.OBiletClient
{
    public class AuthDataResponse
    {
        public string SessionId { get; set; }

        public string DeviceId { get; set; }

        public object Affiliate { get; set; }

        public int DeviceType { get; set; }

        public object Device { get; set; }

        public string IpCountry { get; set; }
    }
}

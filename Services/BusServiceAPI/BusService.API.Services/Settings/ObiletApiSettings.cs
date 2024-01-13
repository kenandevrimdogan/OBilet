﻿using Microsoft.Extensions.Options;

namespace BusService.API.Services.Settings
{
    public class ObiletApiSettings 
    {
        public string BaseUrl { get; set; }

        public string Endpoint { get; set; }

        public string AuthorizationHeader { get; set; }

        public string Getbuslocations { get; set; }

    }
}
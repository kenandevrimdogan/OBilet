using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusService.API.Models.Request
{
    public class ConnectionRequest
    {
        [JsonProperty("ip-address")]
        public string ipaddress { get; set; }
        public string port { get; set; }
    }
}

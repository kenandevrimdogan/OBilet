using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationBus.API.Models.DTO
{
    public class ConnectionDTO
    {
        [JsonProperty("ip-address")]
        public string ipaddress { get; set; }
        public string port { get; set; }
    }
}

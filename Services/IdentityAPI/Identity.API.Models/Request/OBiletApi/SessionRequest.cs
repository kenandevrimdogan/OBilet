using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.API.Models.Request.OBiletApi
{
    public class SessionRequest
    {
        public int Type { get; set; }

        public ConnectionRequest Connection { get; set; }

        public BrowserRequest Browser { get; set; }
    }
}

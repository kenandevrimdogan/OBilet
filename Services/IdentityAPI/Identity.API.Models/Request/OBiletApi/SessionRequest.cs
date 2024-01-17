using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.API.Models.Request.OBiletApi
{
    public class SessionRequest
    {
        public int type { get; set; }

        public ConnectionRequest connection { get; set; }

        public BrowserRequest browser { get; set; }
    }
}

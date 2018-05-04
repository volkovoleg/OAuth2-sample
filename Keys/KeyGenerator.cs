using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys
{
    public static class KeyGenerator
    {
        private static readonly string _secret = "IxrAjDoa2FqElO7IhrSrUJELhUckePEPVpaePlS_Xaw";
        private static readonly string _audience = "099153c2625149bc8ecb3e85e03f0022";

        public static string Audience => _audience;
        public static string Secret => _secret;
    }
}

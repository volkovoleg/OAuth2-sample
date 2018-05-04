using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ResourceServer.Attributes
{
    [AttributeUsage(AttributeTargets.All, Inherited = false)]
    public class CustomAuthorizeAttribute: AuthorizeAttribute
    {
    }
}
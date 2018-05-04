using System.Web.Http;
using ResourceServer.Attributes;

namespace ResourceServer.Controllers
{
    public class TestController : ApiController
    {
        [CustomAuthorize]
        [Route("api/test")]
        public IHttpActionResult Get()
        {
            return Ok("success");
        }
    }
}

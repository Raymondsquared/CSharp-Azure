using System.Web.Http;
using WebApiApplication.Services;

namespace WebApiApplication.Controllers
{
    public class RRController : ApiController
    {
        private readonly RRService _rrService;

        public RRController(RRService rrService)
        {
            _rrService = rrService;
        }

        [Route("api/RR")]
        public string GetAll()
        {
            return _rrService.GetAll();
        }
    }
}

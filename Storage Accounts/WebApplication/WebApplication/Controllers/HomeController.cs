using System.Web.Mvc;
using WebApplication.Services.Abstractions;
using WebApplication.Services.Implementations;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlobService _blobService;

        public HomeController()
        {
            _blobService = new BlobService();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Blob()
        {
            ViewBag.Message = "Blob.";

            return View();
        }

        [HttpPost]
        public ActionResult Upload()
        {
            ViewBag.Message = "Blob.";
            
            _blobService.Upload();

            return View("Blob");
        }

        [HttpPost]
        public ActionResult List()
        {
            ViewBag.Message = "Blob.";
            
            ViewBag.Files = _blobService.Get();

            return View("Blob");
        }

        [HttpPost]
        public ActionResult Download()
        {
            ViewBag.Message = "Blob.";

            _blobService.Download();

            return View("Blob");
        }

        [HttpPost]
        public ActionResult Delete()
        {
            ViewBag.Message = "Blob.";

            _blobService.Delete();

            return View("Blob");
        }
    }
}
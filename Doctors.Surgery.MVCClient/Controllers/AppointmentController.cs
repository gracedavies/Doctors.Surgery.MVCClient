using System.Web.Mvc;

namespace Doctors.Surgery.MVCClient.Controllers
{
    public class AppointmentController : Controller
    {

        public ActionResult Index()
        {
            ViewData["Hello"] = "Hello there";
            return View();
        }

    }
}

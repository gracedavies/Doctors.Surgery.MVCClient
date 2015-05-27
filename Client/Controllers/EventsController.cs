namespace Client.Controllers
{
    using System.Web.Mvc;
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult AppointmentSearch(string button)
        {
            var buttonv = Request.Form["appointment"];
            return View();
        }
    }
}
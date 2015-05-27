using System;
using System.Security.Cryptography;
using Doctors.Surgery.Contracts.Rest;

namespace Client.Controllers
{
    using System.Threading.Tasks;
    using WebClient;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        private AppointmentServiceClient _appointmentServiceClient = new AppointmentServiceClient();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> PostbackTest(Appointment appointment)
        {
            return View("Index", await _appointmentServiceClient.MakeAppointment(new Appointment() { Name = appointment.Name }));
        }
    }
}

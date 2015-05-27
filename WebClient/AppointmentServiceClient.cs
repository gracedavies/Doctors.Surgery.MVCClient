namespace WebClient
{
    using Newtonsoft.Json;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Doctors.Surgery.Contracts.Rest;

    public class AppointmentServiceClient
    {
        private const string uri = "http://localhost:9934/appointments?name=";

        public async Task<Appointment> MakeAppointment(Appointment appointment)
        {
            using (var httpClient = new HttpClient())
            {
                return JsonConvert.DeserializeObject<Appointment>(await httpClient.GetStringAsync(uri + appointment.Name));
            }
        }

    }
}

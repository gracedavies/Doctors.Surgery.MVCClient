using System.Web;
using System.Web.Mvc;

namespace Doctors.Surgery.MVCClient
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

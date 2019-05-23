using System.Web;
using System.Web.Mvc;

namespace MatheusAugusto10001811
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

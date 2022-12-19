using System.Web.Mvc;

namespace Horari
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters ( GlobalFilterCollection filters )
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

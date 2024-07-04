using System.Web;
using System.Web.Mvc;

namespace NtkK22CNT4Lesson11_2210900033
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

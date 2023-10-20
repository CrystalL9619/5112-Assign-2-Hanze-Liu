using System.Web;
using System.Web.Mvc;

namespace _5112_Assign_2_Hanze_Liu
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

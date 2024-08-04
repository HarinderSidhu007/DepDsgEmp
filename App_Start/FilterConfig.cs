using System.Web;
using System.Web.Mvc;

namespace WebApplication2_DepDsgEmp_1147
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

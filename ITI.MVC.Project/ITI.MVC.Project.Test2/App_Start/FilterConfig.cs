using System.Web;
using System.Web.Mvc;

namespace ITI.MVC.Project.Test2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

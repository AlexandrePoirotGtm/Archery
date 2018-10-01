using System.Web.Mvc;

namespace Archery.Areas.BackOffice
{
    public class BackofficeAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "BackOffice";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "BackOffice_default",
                "BackOffice/{controller}/{action}/{id}",
                new { controller = "DashBoard", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
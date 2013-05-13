using System.Web.Mvc;

namespace KrabsBlogEngine.Areas.SimpleMembershipAdministration
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin",
                "Admin/{controller}/{action}/{id}",
                new {controller="Main", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

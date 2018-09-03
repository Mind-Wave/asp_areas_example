using System.Web.Mvc;

namespace Areas_Anipchenko.Areas.AreaTwo
{
    public class AreaTwoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AreaTwo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AreaTwo_default",
                "AreaTwo/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
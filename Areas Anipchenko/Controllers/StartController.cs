using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas_Anipchenko.Controllers
{
    [RouteArea("AreaTird/Start")]//создаём новую Area и переносим(возможно копируем или добавляем новый машрут к нему) наш контроллер Start по новому пути AreaTird/Start
    //ВАЖНО: Мы добавляем именно область и машрут, потому как если мы добавим просто AreaTird, то и URL нам придётся вводить "your_domain/AreaTird/Index"
    public class StartController : Controller
    {
        // GET: Start
        [Route("Index")]//переподключаем этот метод к нашей новой области AreaTird/Start
        public ActionResult Index()
        {
            return View();
        }
    }
}
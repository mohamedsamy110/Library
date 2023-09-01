using day16.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace day16.Controllers
{
    public class dataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test() 
        {
            var bkVM = new TestViewModel()
            {
                Id = 1,
                Name = "Study in Scarlet",
                Price = "2500dollar",
                Category = "flbiu",
                AuthorId = 1,
                Color = "red",
                Age= 35

                
            };

            return View("view1",bkVM);
        
        }

        public IActionResult SetSession() 
        {

            HttpContext.Session.SetInt32("Age", 21);
            HttpContext.Session.SetString("Name", "Mohamed");

            return Content("session has been setted");
        
        }

        public IActionResult ReadSession() 
        {
            var name = HttpContext.Session.GetString("Name");
            var age = HttpContext.Session.GetInt32("Age");

            return Content($"Name: {name} , Age: {age}");
        }

        public IActionResult SetCookie()
        {
            var cookeOptions = new CookieOptions()
            {
                Expires = DateTime.Now.AddHours(4),
            };

            HttpContext.Response.Cookies.Append("Dept", "day17", cookeOptions);
            HttpContext.Response.Cookies.Append("Theme", "Dark Mood", cookeOptions);

            return Content("cookie has setted");
        }

        public IActionResult ReadCookie() 
        {
            var dept = HttpContext.Request.Cookies.FirstOrDefault(x => x.Key == "Dept");
            var theme = HttpContext.Request.Cookies.FirstOrDefault(x => x.Key == "Theme");

            return Content($"cookie has read,Dept: {dept} , Theme: {theme} ");
        }

    }
}

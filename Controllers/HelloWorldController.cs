using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            // return "This is my default action...";
            return View(); 
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int NumTimes = 2)
        {
            // return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}"); 
            // return "This is the Welcome action method...";
            ViewData["Message"] = "Hello " + name; 
            ViewData["NumTimes"] = NumTimes; 

            return View();
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace renderviews.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]
        [Route("")]
        public IActionResult Method()
        {
            return View("Index");
        }
        [HttpPost]
        [Route("result")]
        public IActionResult OtherMethod(string sel1, string sel2, string name, string comment)
        {
            ViewBag.name = name;
            ViewBag.location = sel1;
            ViewBag.language = sel2;
            ViewBag.comment = comment;
            return View("Result");
        }
    }
}

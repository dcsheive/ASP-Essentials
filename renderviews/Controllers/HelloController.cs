using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace renderviews.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public IActionResult Method()
        {
            // Will redirect to the "OtherMethod" method
            return RedirectToAction("OtherMethod", new { Food = "sandwiches", Quantity = 5 });
        }
        [HttpGet]
        [Route("other/{Food}/{Quantity}")]
        public IActionResult OtherMethod(string Food, int Quantity)
        {
            ViewBag.Example = $"I ate {Quantity} {Food}.";
            return View("Index");
        }
    }
}

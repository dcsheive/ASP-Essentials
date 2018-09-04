using Microsoft.AspNetCore.Mvc;
namespace firstaspnet.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public string Index()
        {
            return "This is my index!";
        }
        [HttpGet]       //type of request
        [Route("projects")]     //associated route string (exclude the leading /)
        public string p()
        {
            return "These are my projects!";
        }
        [HttpGet]       //type of request
        [Route("contact")]     //associated route string (exclude the leading /)
        public string c()
        {
            return "This is my contact!";
        }

    }
}

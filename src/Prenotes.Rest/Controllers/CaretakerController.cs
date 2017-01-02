
using Microsoft.AspNetCore.Mvc;

namespace Prenotes.Rest.Controllers {

    public class CaretakerController : Controller {
        
        public CaretakerController() {

        }

        [Route("api/caretaker"), HttpGet]
        public string SayHello() {
            return "Hello";
        }
    }
}
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly StoreContext storeContext;

        public BuggyController(StoreContext storeContext)
        {
            this.storeContext = storeContext;
        }

        [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest()
        {
            var thing = storeContext.Products.Find(42);
            if(thing == null)
            return NotFound();
            return Ok();
        }

    }
}
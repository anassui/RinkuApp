using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RinkuApp.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return this.View();
        }
     
    }
}

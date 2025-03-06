using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesingPattersAsp.Controllers
{
    public class GeneretorFileController : Controller
    {
      public IActionResult Index()
        {
            return View();
        }


        public IActionResult CreateFile(int optionFile)
        {
            try
            {
                return Json(optionFile == 1 ? "Json" : "Pipe");
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}

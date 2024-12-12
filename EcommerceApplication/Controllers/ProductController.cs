using EcommerceApplication.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApplication.Web.Controllers
{
    public class ProductController : Controller
    {
        public ProductController()
        {
            
               
        }
        public IActionResult Index()
        {
            
            return View();
        }
    }
}

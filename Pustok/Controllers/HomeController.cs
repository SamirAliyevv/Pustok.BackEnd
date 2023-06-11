using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.DAL;
using Pustok.ViewModels;
using Pustok.Entities;

namespace Pustok.Controllers
{
    public class HomeController : Controller
    {

        private readonly RelationsBooksShop _context;
        public HomeController(RelationsBooksShop context)
        {
            _context = context;

        }



        public IActionResult Index()
        {

            ViewBag.title = "Home";

            IndexPage indexPage = new IndexPage
            {
                Books = _context.Books.Include(x => x.BooksImages).Include(x => x.Authors).Include(x => x.BooksTags).ToList(),
                Sliders = _context.Sliders.ToList()


            };
            
            return View(indexPage);


        }

    }
}

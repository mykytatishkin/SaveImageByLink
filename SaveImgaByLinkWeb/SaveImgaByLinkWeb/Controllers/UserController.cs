using Microsoft.AspNetCore.Mvc;
using SaveImgaByLinkWeb.Models;

namespace SaveImgaByLinkWeb.Controllers
{
    public class UserController : Controller
    {
        private readonly ImageContext _context;
        public UserController(ImageContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            User userInDb = _context.Users.Where(u => u.Name == u.Name &&
                u.Password == user.Password).FirstOrDefault();
            if (userInDb == null)
            {
                return RedirectToAction("Registration");
            }
            else
            {

                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

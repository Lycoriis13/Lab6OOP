using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        private static List<User> users = new List<User>
        {
            new User { Id = 1, FirstName = "Яна", LastName = "Легка", Email = "y.lehka_fit_3_23_b_d@knute.edu.ua", RegistrationDate = DateTime.Now.AddDays(-10) },
            new User { Id = 2, FirstName = "Владислав", LastName = "Антонюк", Email = "vladAn@gmail.com", RegistrationDate = DateTime.Now.AddDays(-20) }
        };

        public IActionResult Index()
        {
            // Додайте відладкове повідомлення
            Console.WriteLine("Index method is called.");
            return View(users);
        }

        public IActionResult Details(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound(); // Використовуємо NotFound() у ASP.NET Core MVC
            }
            return View(user);
        }
    }
}

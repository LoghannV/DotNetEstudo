using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using MVCprojeto.Models;
using MVCprojeto.Validator;

namespace MVCprojeto.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();
            return View("Index", user);
            
        }
        [HttpPost]
        public IActionResult teste(UserViewModel user)
        {
            UserValidator validator = new UserValidator();
            ValidationResult result = validator.Validate(user);


            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }

            }
            
            user.Email = "email enviado";

            return View("Index",user);
        }
    }
}

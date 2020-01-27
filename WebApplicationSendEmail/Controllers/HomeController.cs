using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplicationSendEmail.Helper;
using WebApplicationSendEmail.Model;

namespace WebApplicationSendEmail.Controllers
{

    public class HomeController : Controller
    {
        private EmailHelper _emailHelper;

        public HomeController(EmailHelper emailHelper)
        {
            _emailHelper = emailHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendEmail()
        {
            var emailModel =
                new EmailModel("gscaduto@sabesp.com.br", // To destination_email@test.com
                               "Email Test", // Subject
                               "Sending Email using Asp.Net Core.", // Message
                               false // IsBodyHTML
                               );

            _emailHelper.SendEmail(emailModel);

            return RedirectToAction("Index");
        }
    }
}
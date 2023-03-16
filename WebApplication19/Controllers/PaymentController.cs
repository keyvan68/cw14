using Microsoft.AspNetCore.Mvc;
using WebApplication19.DAl;
using WebApplication19.Models;
using WebApplication19.Models.ViewModels;

namespace WebApplication19.Controllers
{
    public class PaymentController : Controller
    {
        PaymentRipository paymentRipository = new();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CompleteOrder()
        {

            TempData["captcha"] = GenerateCaptcha();
            TempData.Keep("captcha");

            return View();
        }
        [HttpPost]
        public IActionResult CompleteOrder(PaymentViewModel payment)
        {
            if (TempData["captcha"].ToString() == payment.Captcha.ToString())
            {
            paymentRipository.AddPayment(payment);
            return RedirectToAction("Index","Home");    
            }
            else
            {
                TempData["message"] = "لطفا کپچا را درست وارد کنید";
            }
            return RedirectToAction("CompleteOrder");
        }
        public string GenerateCaptcha()
        {
            Random generator = new Random();
            String r = generator.Next(0, 100000).ToString("D5");
            return r;
        }
    }
}

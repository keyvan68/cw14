using System.ComponentModel.DataAnnotations;

namespace WebApplication19.Models.ViewModels
{
    public class PaymentViewModel
    {
        [StringLength(16,ErrorMessage ="16 رقمی باشد", MinimumLength = 16)]
        public string CardNumber { get; set; }
        public int Price { get; set; }
        [StringLength(5, ErrorMessage = "16 رقمی باشد", MinimumLength = 5)]
        public string Captcha { get; set; }
        
        //public string ConfirmCaptcha { get; set; }
    }
}

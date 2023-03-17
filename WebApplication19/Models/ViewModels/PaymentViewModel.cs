using System.ComponentModel.DataAnnotations;

namespace WebApplication19.Models.ViewModels
{
    public class PaymentViewModel
    {
        public string CardNumber { get; set; }

        [StringLength(4, ErrorMessage = "4 رقمی باشد", MinimumLength = 4)]
        public string CardNumber1 { get; set; }

        [StringLength(4, ErrorMessage = "4 رقمی باشد", MinimumLength = 4)]
        public string CardNumber2 { get; set; }

        [StringLength(4, ErrorMessage = "4 رقمی باشد", MinimumLength = 4)]
        public string CardNumber3 { get; set; }

        [StringLength(4, ErrorMessage = "4 رقمی باشد", MinimumLength = 4)]
        public string CardNumber4 { get; set; }


        public int Price { get; set; }
        [StringLength(5, ErrorMessage = "5 رقمی باشد", MinimumLength = 5)]
        public string Captcha { get; set; }

        //public string ConfirmCaptcha { get; set; }
    }
}

using WebApplication19.Models;
using WebApplication19.Models.ViewModels;

namespace WebApplication19.DAl
{
    public class PaymentRipository
    {
        public void AddPayment(PaymentViewModel paymentViewModel)
        {
            var payment = new Payment
            {
                CardNumber = paymentViewModel.CardNumber1 + paymentViewModel.CardNumber2 + paymentViewModel.CardNumber3 + paymentViewModel.CardNumber4,
                Price = paymentViewModel.Price
            };
            DataStorage.Payments.Add(payment);
        }
    }

}

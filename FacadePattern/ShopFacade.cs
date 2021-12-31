using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class ShopFacade
    {
        private static ShopFacade INSTANCE = new ShopFacade();

        private AccountService accountService;
        private PaymentService paymentService;
        private ShippingService shippingService;
        private EmailService emailService;

        private ShopFacade()
        {
            accountService = new AccountService();
            paymentService = new PaymentService();
            shippingService = new ShippingService();
            emailService = new EmailService();
        }

        public static ShopFacade getInstance()
        {
            return INSTANCE;
        }

        public void BuyProductByCashWithFreeShipping(string email)
        {
            accountService.GetAccount(email);
            paymentService.PaymentByCash();
            shippingService.FreeShipping();
            emailService.SendMail(email);
            Console.WriteLine("Done\n");
        }

        public void BuyProductByPaypalWithStandardShipping(string email)
        {
            accountService.GetAccount(email);
            paymentService.PaymentByPaypal();
            shippingService.StandardShipping();
            emailService.SendMail(email);
            Console.WriteLine("Done\n");
        }
    }
}

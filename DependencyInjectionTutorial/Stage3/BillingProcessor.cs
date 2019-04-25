using System;

namespace DependencyInjectionTutorial.Stage3
{
    class BillingProcessor: IBillingProcessor
    {
        public void ProcessPayment(string customerName,string creditCard,string email)
        {
            Console.WriteLine("Payment Processed");
        }
    }
    public interface IBillingProcessor
    {
        void ProcessPayment(string customerName, string creditCard, string email);
    }
}

using System;

namespace DependencyInjectionTutorial.Stage1
{
    class BillingProcessor
    {
        public void ProcessPayment(string customerName,string creditCard,string email)
        {
            Console.WriteLine("Payment Processed");
        }
    }
}

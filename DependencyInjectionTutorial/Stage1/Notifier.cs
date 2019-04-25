using System;

namespace DependencyInjectionTutorial.Stage1
{
    public class Notifier
    {
        public void SendReceipt(OrderInfo order)
        {
            Console.WriteLine("Send Receipt");
        }
    }
}

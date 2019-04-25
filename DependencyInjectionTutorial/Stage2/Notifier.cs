using System;
using DependencyInjectionTutorial.Stage1;

namespace DependencyInjectionTutorial.Stage2
{
    public class Notifier: INotifier
    {
        public void SendReceipt(OrderInfo order)
        {
            Console.WriteLine("Send Receipt");
        }
    }

    public interface INotifier
    {
        void SendReceipt(OrderInfo order);
    }
}

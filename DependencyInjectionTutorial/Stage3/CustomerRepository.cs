using System;

namespace DependencyInjectionTutorial.Stage3
{
    public class CustomerRepository: ICustomerRepository
    {
        public void Save()
        {
            Console.WriteLine("Customer Saved");
        }
    }

    public interface ICustomerRepository
    {
        void Save();
    }
}

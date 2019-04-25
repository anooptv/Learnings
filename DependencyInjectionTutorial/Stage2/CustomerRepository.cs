using System;

namespace DependencyInjectionTutorial.Stage2
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

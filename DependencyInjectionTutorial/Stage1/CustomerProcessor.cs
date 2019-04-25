using System;

namespace DependencyInjectionTutorial.Stage1
{
    public class CustomerProcessor
    {
        public void UpdateCustomerOrder(string customerName, string product)
        {
            CustomerRepository customerRepository = new CustomerRepository();
            ProductRepository productRepository = new ProductRepository();
            customerRepository.Save();
            productRepository.Save();
            Console.WriteLine("Customer record updated with purchase of product ");
        }
    }
}

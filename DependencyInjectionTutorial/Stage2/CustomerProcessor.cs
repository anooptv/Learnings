using System;

namespace DependencyInjectionTutorial.Stage2
{
    public class CustomerProcessor: ICustomerProcessor
    {
        public CustomerProcessor(ICustomerRepository customerRepository, IProductRepository productRepository)
        {
            _CustomerRepository = customerRepository;
            _ProductRepository = productRepository;
        }
        ICustomerRepository _CustomerRepository;
        IProductRepository  _ProductRepository;
        public void UpdateCustomerOrder(string customerName, string product)
        {
            _CustomerRepository.Save();
            _ProductRepository.Save();
            Console.WriteLine("Customer record updated with purchase of product ");
        }
    }
    public interface ICustomerProcessor
    {
        void UpdateCustomerOrder(string customerName, string product);
    }
}

using System;

namespace DependencyInjectionTutorial.Stage2
{
    public class ProductRepository: IProductRepository
    {
        public void Save()
        {
            Console.WriteLine("Product Saved");
        }
    }

    public interface IProductRepository
    {
        void Save();
    }
}

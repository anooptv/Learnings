using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionTutorial.Stage1
{
    public class ProductRepository
    {
        public void Save()
        {
            Console.WriteLine("Product Saved");
        }
    }
}

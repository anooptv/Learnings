using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionTutorial.Stage1
{
    public class CustomerRepository
    {
        public void Save()
        {
            Console.WriteLine("Customer Saved");
        }
    }
}

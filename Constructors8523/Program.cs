using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors8523
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop1 = new Shop()
            {
                Id = 1,
                Name = "Vatan"
            };
            Console.WriteLine("ID: " + shop1.Id + " Name: " + shop1.Name);
            
            Shop shop2 = new Shop(2, "Mediamarkt");
            Console.WriteLine($"ID: {shop2.Id} Name: {shop2.Name}");

            CustomerManager manager1 = new CustomerManager();
            manager1.List();
            CustomerManager manager2 = new CustomerManager(40);
            manager2.List();

            
            Console.ReadLine();
        }
    }
    class Shop 
    { 
        public int Id { get; set; }
        public string Name { get; set; }

        public Shop() // default constructor
        { 
        
        }
        public Shop(int id,string name) // parametreli constructor - constructor overLoad
        {
            Id = id;
            Name = name;
        }
    }
    class CustomerManager 
    {
        private int _count = 20;

        public CustomerManager() 
        {
            //_count = 20; // İlk değer ataması Constructor'da da yapılabilir
        }
        public CustomerManager(int count) 
        {
            _count = count;
        }
        
        public void List() 
        {
            Console.WriteLine("Listed " + _count + " items");
        }
    }
}

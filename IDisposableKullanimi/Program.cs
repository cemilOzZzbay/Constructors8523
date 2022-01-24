using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposableKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Id = 1,
                Name="Çağıl"
            };
            Console.WriteLine($"ID: {person.Id} Name: {person.Name}");
            person.Dispose();
            Console.ReadLine();
        }
    }
    class Person:IDisposable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person()
        {
            Console.WriteLine("Person constructor executed.");
        }
        #region Dispose Operation
        protected bool disposed = false;
        protected virtual void Dispose(bool disposing) 
        {
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);             //(System.IDisposable.Dispose)
            GC.SuppressFinalize(this); //(System.GC(Garbage Collector).SuppressFinalize)
        }
        #endregion
    }
}

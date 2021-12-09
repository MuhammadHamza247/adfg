using System;

namespace Classfundamental
{
        public class Person
        {
            public string FirstName;
            public string LastName;
            public void introduced()
             {
            Console.WriteLine("Hi my name is "+ FirstName +" "+ LastName + ".");
             }
        }
    
    class Program
    {
        static void Main(string[] args)
        {
        Person per = new Person();
        per.FirstName ="Muhammad";
        per.LastName ="Hamza";
        per.introduced();
        }
    }
        
}

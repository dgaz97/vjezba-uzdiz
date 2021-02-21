using System;
using uzorci_vjezba.FactoryMethod.Abstractions;
using uzorci_vjezba.FactoryMethod.Creators;
using uzorci_vjezba.Strategy;
using uzorci_vjezba.TemplateMethod;

namespace uzorci_vjezba
{
    class Program
    {
        static void Main(string[] args)
        {
            if (false)//Testing Template Method
            {
                Console.WriteLine("#########################Testing Template method#########################");

                Message m = new StringMessage();
                Console.WriteLine(m.ExecuteMessage());

                m = new IntegerMessage();
                Console.WriteLine(m.ExecuteMessage());

                m = new DoubleMessage();
                Console.WriteLine(m.ExecuteMessage());

                Console.WriteLine("#########################Template method done#########################");
            }
            

            Console.ReadKey();

        }
    }
}

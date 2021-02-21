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
            if (false)//Testing Strategy
            {
                Console.WriteLine("#########################Testing Strategy#########################");

                //This main program is the client

                StrategyContext strategyContext = new StrategyContext(2.5, 3.5);
                try
                {
                    strategyContext.executeOperation();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                strategyContext.setStrategy(new AdditionStrategy());
                Console.WriteLine(strategyContext.executeOperation());

                strategyContext.setStrategy(new MultiplicationStrategy());
                Console.WriteLine(strategyContext.executeOperation());

                strategyContext.setStrategy(new SubtractionStrategy());
                Console.WriteLine(strategyContext.executeOperation());

                Console.WriteLine("#########################Strategy done#########################");
            }

            Console.ReadKey();

        }
    }
}

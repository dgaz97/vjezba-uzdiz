using System;
using uzorci_vjezba.AbstractFactory;
using uzorci_vjezba.AbstractFactory.Hyundai;
using uzorci_vjezba.AbstractFactory.ICars;
using uzorci_vjezba.AbstractFactory.Nissan;
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

            if (false)//Testing Factory method
            {
                Console.WriteLine("#########################Testing Factory method#########################");

                AbstractCreator creator1 = new TenSpammerCreator();
                AbstractCreator creator2 = new TwentySpammerCreator();

                ISpammer spammer1 = creator1.CreateSpammer();
                ISpammer spammer2 = creator2.CreateSpammer();

                Console.WriteLine(spammer1.SpamMessage("A message, ten times"));
                Console.WriteLine(spammer2.SpamMessage("A message, twenty times"));

                Console.WriteLine("#########################Factory method done#########################");
            }
            if (true)//Testing Abstract factory
            {
                Console.WriteLine("#########################Testing Abstract factory#########################");

                CarFactory factory;
                ISportsCar sportsCar;
                ISedan sedan;

                factory = new NissanFactory();
                sportsCar = factory.createSportsCar();
                sedan = factory.createSedan();

                Console.WriteLine(sedan.doSomething());
                Console.WriteLine(sportsCar.doSomethingElse());

                factory = new HyundaiFactory();
                sportsCar = factory.createSportsCar();
                sedan = factory.createSedan();

                Console.WriteLine(sedan.doSomething());
                Console.WriteLine(sportsCar.doSomethingElse());
                
                Console.WriteLine("#########################Abstract factory done#########################");
            }

            Console.ReadKey();

        }
    }
}

using System;

namespace uzorci_vjezba.TemplateMethod
{
    public class IntegerMessage : Message
    {
        protected override string AddNumbers(double a, double b)
        {
            return ((int)(a + b)).ToString();
        }

        protected override string ConcatenateNumbers(double a, double b)
        {
            throw new NotImplementedException();
        }

        protected override string IdentifyOperators()
        {
            return "I work with integers";
        }

        protected override string IdentifyType()
        {
            return "This is an integer message";
        }

        protected override bool WorksWithNumbers()
        {
            return true;
        }
    }
}

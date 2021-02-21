using System;

namespace uzorci_vjezba.TemplateMethod
{
    public class DoubleMessage : Message
    {
        protected override string AddNumbers(double a, double b)
        {
            return ((a + b)).ToString();
        }

        protected override string ConcatenateNumbers(double a, double b)
        {
            throw new NotImplementedException();
        }

        protected override string IdentifyOperators()
        {
            return "I work with doubles";
        }

        protected override string IdentifyType()
        {
            return "This is a doubles message";
        }

        protected override bool WorksWithNumbers()
        {
            return true;
        }
    }
}

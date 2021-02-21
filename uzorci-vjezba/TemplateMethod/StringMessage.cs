using System;

namespace uzorci_vjezba.TemplateMethod
{
    public class StringMessage : Message
    {
        protected override string AddNumbers(double a, double b)
        {
            throw new NotImplementedException();
        }

        protected override string IdentifyType()
        {
            return "This is a string message";
        }

        protected override string IdentifyOperators()
        {
            return "I work with strings";
        }

        protected override bool WorksWithNumbers()
        {
            return false;
        }

        protected override string ConcatenateNumbers(double a, double b)
        {
            return $"{a}{b}";
        }
    }
}

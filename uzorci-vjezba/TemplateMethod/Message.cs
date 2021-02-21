using System.Text;

namespace uzorci_vjezba.TemplateMethod
{
    public abstract class Message
    {
        public string ExecuteMessage()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(IdentifyType());
            sb.AppendLine(IdentifyOperators());
            if (WorksWithNumbers())
            {
                sb.AppendLine(AddNumbers(2.33, 1.44));
            }
            else
            {
                sb.AppendLine(ConcatenateNumbers(2.33, 1.44));
            }
            return sb.ToString();

        }
        protected abstract string IdentifyType();
        protected abstract string IdentifyOperators();
        protected abstract string AddNumbers(double a, double b);
        protected abstract bool WorksWithNumbers();
        protected abstract string ConcatenateNumbers(double a, double b);
    }
}

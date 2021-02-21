using System;

namespace uzorci_vjezba.Strategy
{
    public class StrategyContext
    {
        private IStrategy _strategy;
        public double a { get; set; }
        public double b { get; set; }
        public StrategyContext(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void setStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public double executeOperation ()
        {
            if (_strategy == null) throw new Exception("Strategy hasn't been set");
            return _strategy.execute(a, b);
        }
    }
}

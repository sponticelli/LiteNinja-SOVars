using System;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class DoubleRef : ASORef<double>
    {
        public DoubleRef()
        {
        }

        public DoubleRef(double value) : base(value)
        {
        }

        public DoubleRef(ASOVar<double> reference) : base(reference)
        {
        }
    }
}
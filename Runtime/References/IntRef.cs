using System;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class IntRef : ASORef<int>
    {
        public IntRef()
        {
        }

        public IntRef(int value) : base(value)
        {
        }

        public IntRef(ASOVar<int> reference) : base(reference)
        {
        }
    }
}
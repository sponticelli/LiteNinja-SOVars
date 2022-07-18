using System;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class BoolRef : ASORef<bool>
    {
        public BoolRef()
        {
        }

        public BoolRef(bool value) : base(value)
        {
        }

        public BoolRef(ASOVar<bool> reference) : base(reference)
        {
        }
    }
}
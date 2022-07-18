using System;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class FloatRef : ASORef<float>
    {
        public FloatRef()
        {
        }

        public FloatRef(float value) : base(value)
        {
        }

        public FloatRef(ASOVar<float> reference) : base(reference)
        {
        }
    }
}
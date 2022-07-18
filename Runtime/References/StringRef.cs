using System;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class StringRef : ASORef<string>
    {
        public StringRef()
        {
        }

        public StringRef(string value) : base(value)
        {
        }

        public StringRef(ASOVar<string> reference) : base(reference)
        {
        }
    }
}
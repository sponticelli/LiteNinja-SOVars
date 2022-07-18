using System;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class DateTimeRef : ASORef<DateTime>
    {
        public DateTimeRef()
        {
        }

        public DateTimeRef(DateTime value) : base(value)
        {
        }

        public DateTimeRef(ASOVar<DateTime> reference) : base(reference)
        {
        }
    }
}
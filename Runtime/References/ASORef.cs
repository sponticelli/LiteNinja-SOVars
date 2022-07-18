using System;

namespace LiteNinja.SOVars
{
    [Serializable]
    public abstract class ASORef<T>
    {
        public bool useValue = true;
        public T value;
        public ASOVar<T> reference;


        public ASORef()
        {
        }

        public ASORef(T value)
        {
            this.value = value;
            useValue = true;
        }

        public ASORef(ASOVar<T> reference)
        {
            this.reference = reference;
            useValue = false;
        }

        public T Value()
        {
            return useValue ? value : reference.Value;
        }
    }
}
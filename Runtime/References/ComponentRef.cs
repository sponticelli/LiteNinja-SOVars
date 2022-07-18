using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class ComponentRef : ASORef<Component>
    {
        public ComponentRef()
        {
        }

        public ComponentRef(Component value) : base(value)
        {
        }

        public ComponentRef(ASOVar<Component> reference) : base(reference)
        {
        }
    }
}
using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class ColorRef : ASORef<Color>
    {
        public ColorRef()
        {
        }

        public ColorRef(Color value) : base(value)
        {
        }

        public ColorRef(ASOVar<Color> reference) : base(reference)
        {
        }
    }
}
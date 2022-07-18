using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class Texture2DRef : ASORef<Texture2D>
    {
        public Texture2DRef()
        {
        }

        public Texture2DRef(Texture2D value) : base(value)
        {
        }

        public Texture2DRef(ASOVar<Texture2D> reference) : base(reference)
        {
        }
    }
}
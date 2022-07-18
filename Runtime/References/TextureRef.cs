using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class TextureRef : ASORef<Texture>
    {
        public TextureRef()
        {
        }

        public TextureRef(Texture value) : base(value)
        {
        }

        public TextureRef(ASOVar<Texture> reference) : base(reference)
        {
        }
    }
}
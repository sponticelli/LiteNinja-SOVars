using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class SpriteRef : ASORef<Sprite>
    {
        public SpriteRef()
        {
        }

        public SpriteRef(Sprite value) : base(value)
        {
        }

        public SpriteRef(ASOVar<Sprite> reference) : base(reference)
        {
        }
    }
}
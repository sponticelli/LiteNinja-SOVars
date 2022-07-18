using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class Vector2Ref : ASORef<Vector2>
    {
        public Vector2Ref()
        {
        }

        public Vector2Ref(Vector2 value) : base(value)
        {
        }

        public Vector2Ref(ASOVar<Vector2> reference) : base(reference)
        {
        }
    }
}
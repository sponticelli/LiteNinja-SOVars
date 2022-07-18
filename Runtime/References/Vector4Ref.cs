using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class Vector4Ref : ASORef<Vector4>
    {
        public Vector4Ref()
        {
        }

        public Vector4Ref(Vector4 value) : base(value)
        {
        }

        public Vector4Ref(ASOVar<Vector4> reference) : base(reference)
        {
        }
    }
}
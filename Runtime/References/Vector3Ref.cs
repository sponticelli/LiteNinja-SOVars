using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class Vector3Ref : ASORef<Vector3>
    {
        public Vector3Ref()
        {
        }

        public Vector3Ref(Vector3 value) : base(value)
        {
        }

        public Vector3Ref(ASOVar<Vector3> reference) : base(reference)
        {
        }
    }
}
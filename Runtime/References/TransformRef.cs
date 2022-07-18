using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class TransformRef : ASORef<Transform>
    {
        public TransformRef()
        {
        }

        public TransformRef(Transform value) : base(value)
        {
        }

        public TransformRef(ASOVar<Transform> reference) : base(reference)
        {
        }
    }
}
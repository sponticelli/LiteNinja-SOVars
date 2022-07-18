using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class RectTransformRef : ASORef<RectTransform>
    {
        public RectTransformRef()
        {
        }

        public RectTransformRef(RectTransform value) : base(value)
        {
        }

        public RectTransformRef(ASOVar<RectTransform> reference) : base(reference)
        {
        }
    }
}
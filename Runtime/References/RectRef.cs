using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class RectRef : ASORef<Rect>
    {
        public RectRef()
        {
        }

        public RectRef(Rect value) : base(value)
        {
        }

        public RectRef(ASOVar<Rect> reference) : base(reference)
        {
        }
    }
}
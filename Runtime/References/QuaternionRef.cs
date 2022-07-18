using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class QuaternionRef : ASORef<Quaternion>
    {
        public QuaternionRef()
        {
        }

        public QuaternionRef(Quaternion value) : base(value)
        {
        }

        public QuaternionRef(ASOVar<Quaternion> reference) : base(reference)
        {
        }
    }
}
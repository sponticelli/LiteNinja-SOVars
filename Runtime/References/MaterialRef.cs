using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class MaterialRef : ASORef<Material>
    {
        public MaterialRef()
        {
        }

        public MaterialRef(Material value) : base(value)
        {
        }

        public MaterialRef(ASOVar<Material> reference) : base(reference)
        {
        }
    }
}
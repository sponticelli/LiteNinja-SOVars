using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [CreateAssetMenu(menuName = "LiteNinja/Variables/Material Var", fileName = "MaterialVar")]
    [Serializable]
    public class MaterialVar : ASOVar<Material>
    {
    }
}
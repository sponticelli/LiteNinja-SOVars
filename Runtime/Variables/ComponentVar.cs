using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [CreateAssetMenu(menuName = "LiteNinja/Variables/Component Var", fileName = "ComponentVar")]
    [Serializable]
    public class ComponentVar : ASOVar<Component>
    {
    }
}
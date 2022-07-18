using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [CreateAssetMenu(menuName = "LiteNinja/Variables/Float Var", fileName = "FloatVar")]
    [Serializable]
    public class FloatVar : ASOVar<float>
    {
    }
}
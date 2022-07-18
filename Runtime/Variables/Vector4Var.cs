using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [CreateAssetMenu(menuName = "LiteNinja/Variables/Vector4 Var", fileName = "Vector4Var")]
    [Serializable]
    public class Vector4Var : ASOVar<Vector4>
    {
    }
}
using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [CreateAssetMenu(menuName = "LiteNinja/Variables/Vector3 Var", fileName = "Vector3Var")]
    [Serializable]
    public class Vector3Var : ASOVar<Vector3>
    {
    }
}
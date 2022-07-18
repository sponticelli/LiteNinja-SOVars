using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [CreateAssetMenu(menuName = "LiteNinja/Variables/Transform Var", fileName = "TransformVar")]
    [Serializable]
    public class TransformVar : ASOVar<Transform>
    {
    }
}
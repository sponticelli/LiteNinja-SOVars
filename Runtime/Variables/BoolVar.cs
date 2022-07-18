using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [CreateAssetMenu(menuName = "LiteNinja/Variables/Bool Var", fileName = "BoolVar")]
    [Serializable]
    public class BoolVar : ASOVar<bool>
    {
    }
}
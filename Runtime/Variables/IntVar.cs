using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [CreateAssetMenu(menuName = "LiteNinja/Variables/Int Var", fileName = "IntVar")]
    [Serializable]
    public class IntVar : ASOVar<int>
    {
    }
}
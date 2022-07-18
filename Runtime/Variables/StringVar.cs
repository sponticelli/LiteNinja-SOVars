using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [CreateAssetMenu(menuName = "LiteNinja/Variables/String Var", fileName = "StringVar")]
    [Serializable]
    public class StringVar : ASOVar<string>
    {
    }
}
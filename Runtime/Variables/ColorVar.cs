using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [CreateAssetMenu(menuName = "LiteNinja/Variables/Color Var", fileName = "ColorVar")]
    [Serializable]
    public class ColorVar : ASOVar<Color>
    {
    }
}
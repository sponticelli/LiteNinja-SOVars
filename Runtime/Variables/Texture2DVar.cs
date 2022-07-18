using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [CreateAssetMenu(menuName = "LiteNinja/Variables/Texture2D Var", fileName = "Texture2DVar")]
    [Serializable]
    public class Texture2DVar : ASOVar<Texture2D>
    {
    }
}
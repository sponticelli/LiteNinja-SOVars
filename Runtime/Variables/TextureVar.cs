using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [CreateAssetMenu(menuName = "LiteNinja/Variables/Texture Var", fileName = "TextureVar")]
    [Serializable]
    public class TextureVar : ASOVar<Texture>
    {
    }
}
using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [CreateAssetMenu(menuName = "LiteNinja/Variables/Sprite Var", fileName = "SpriteVar")]
    [Serializable]
    public class SpriteVar : ASOVar<Sprite>
    {
    }
}
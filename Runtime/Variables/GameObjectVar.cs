using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [CreateAssetMenu(menuName = "LiteNinja/Variables/GameObject Var", fileName = "GameObjectVar")]
    [Serializable]
    public class GameObjectVar : ASOVar<GameObject>
    {
    }
}
using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class GameObjectRef : ASORef<GameObject>
    {
        public GameObjectRef()
        {
        }

        public GameObjectRef(GameObject value) : base(value)
        {
        }

        public GameObjectRef(ASOVar<GameObject> reference) : base(reference)
        {
        }
    }
}
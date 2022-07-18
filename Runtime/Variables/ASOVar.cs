using System;
using LiteNinja.SOEvents;
using LiteNinja.Utils;
using LiteNinja.Utils.Attributes;
using UnityEngine;


namespace LiteNinja.SOVars
{
    [Serializable]
    public abstract class ASOVar<T> : DescribedSO, ISerializationCallbackReceiver
    {
        [SerializeField] private bool _isConstant;
        [SerializeField] private T initialValue;
        [SerializeField] [ReadOnly] private T runtimeValue;

        [SerializeField] private ASOEvent<T> onValueChanged;

        [NonSerialized] private bool initialized;
        
        public void SetRuntimeValue(T newValue)
        {
            Value = newValue;
        }
        
        public T InitialValue => initialValue;

        public T Value
        {
            get
            {
                if (initialized) return runtimeValue;
                runtimeValue = initialValue;
                initialized = true;
                return runtimeValue;
            }

            set
            {
                if (_isConstant)
                {
                    Debug.LogWarning("Trying to set value of constant variable");
                    return;
                }

                initialized = true;
                hideFlags = HideFlags.DontUnloadUnusedAsset;
                runtimeValue = value;
                onValueChanged?.Raise(value);
            }
        }

        public bool IsConstant => _isConstant;

        public virtual void OnAfterDeserialize()
        {
        }

        public virtual void OnBeforeSerialize()
        {
        }
    }
}
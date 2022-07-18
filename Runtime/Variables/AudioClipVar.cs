using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [CreateAssetMenu(menuName = "LiteNinja/Variables/AudioClip Var", fileName = "AudioClipVar")]
    [Serializable]
    public class AudioClipVar : ASOVar<AudioClip>
    {
    }
}
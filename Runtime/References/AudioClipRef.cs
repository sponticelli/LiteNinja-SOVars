using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [Serializable]
    public class AudioClipRef : ASORef<AudioClip>
    {
        public AudioClipRef()
        {
        }

        public AudioClipRef(AudioClip value) : base(value)
        {
        }

        public AudioClipRef(ASOVar<AudioClip> reference) : base(reference)
        {
        }
    }
}
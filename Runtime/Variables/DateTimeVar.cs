using System;
using UnityEngine;

namespace LiteNinja.SOVars
{
    [CreateAssetMenu(menuName = "LiteNinja/Variables/DateTime Var", fileName = "DateTimeVar", order = 0)]
    [Serializable]
    public class DateTimeVar : ASOVar<DateTime>
    {
    }
}
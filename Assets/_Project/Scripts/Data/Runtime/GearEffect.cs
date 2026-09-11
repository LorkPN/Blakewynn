using System;
using Enums;

namespace _Project.Scripts.Data.Runtime
{
    [Serializable]
    public struct GearEffect
    {
        public CharacterStat stat;
        public float magnitude;   // the amount of that stat this effect contributes, e.g. +5 Strength
    }
}
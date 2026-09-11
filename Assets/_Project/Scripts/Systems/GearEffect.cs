using System;
using Data.Enums;

namespace _Project.Scripts.Systems
{
    [Serializable]
    public struct GearEffect
    {
        public CharacterStat stat;
        public float magnitude;   // the amount of that stat this effect contributes, e.g. +5 Strength
    }
}
using System;
using Assets._Project.Scripts.Data.Enums;


namespace Assets._Project.Scripts.Systems.Combat
{
    [Serializable]
    public struct GearEffect
    {
        public CharacterStat stat;
        public float magnitude;   // the amount of that stat this effect contributes, e.g. +5 Strength
    }
}
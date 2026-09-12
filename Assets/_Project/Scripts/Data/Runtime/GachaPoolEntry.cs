using System;
using Assets._Project.Scripts.Data.Definitions;


namespace Assets._Project.Scripts.Data.Runtime
{
    [Serializable]
    public struct GachaPoolEntry
    {
        public CharacterDefinition character;
        public float weight;
    }
}
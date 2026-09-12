using UnityEngine;
using System;


namespace Assets._Project.Scripts.Data.Runtime
{
    [Serializable]
    public class CharacterSkill
    {
        public string skillLineId;
        public int level;
        public CharacterSkill(string skillLineId, int level)
        {
            this.skillLineId = skillLineId;
            this.level = level;
        }
    }
}
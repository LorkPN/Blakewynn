using UnityEngine;

namespace _Project.Scripts.Data.Runtime
{
    [Serializable]
    public class CharacterSkill
    {
        public string skillId;
        public int level;
        public CharacterSkill(string skillId)
        {
            this.skillId = skillId;
            level = 1;
        }
    }
}
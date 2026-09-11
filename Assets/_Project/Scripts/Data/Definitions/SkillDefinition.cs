using UnityEngine;

namespace _Project.Scripts.Data.Definitions
{
    [CreateAssetMenu(fileName = "NewSkill", menuName = "Blakewynn/Skill Definition")]
    public class SkillDefinition : ScriptableObject
    {
        [Header("Identity")]
        public string skillId;
        public string displayName;
        [TextArea] public string description;
        public Sprite skillIcon;
        [Header("Details")]
        public float[] cooldowns;
        public float[] manaCosts;
        public EffectDefinition[] effects; // the effects this skill applies when used
    }
}
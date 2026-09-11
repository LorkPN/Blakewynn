using UnityEngine;
using Enums;

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
        public float cooldown;
        public float manaCost;
        public SkillEffect[] effects; // the effects this skill applies when used
        public TargetLane targetLane; // the lane this skill targets when used
    }
}
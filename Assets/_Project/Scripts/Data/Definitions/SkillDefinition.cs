using UnityEngine;
using Assets._Project.Scripts.Data.Enums;
using Assets._Project.Scripts.Systems.Combat;


namespace Assets._Project.Scripts.Data.Definitions
{
    [CreateAssetMenu(fileName = "NewSkill", menuName = "Blakewynn/Skill Definition")]
    public class SkillDefinition : ScriptableObject
    {
        [Header("Identity")]
        public string skillLineId;    // stable key, e.g. "skill_fireball" — same reasoning as characterId
        public int level;                // the level of this skill in its skill line, e.g. 1, 2, 3, etc.
        public string displayName;
        [TextArea] public string description;
        public Sprite skillIcon;
        [Header("Details")]
        public float cooldown;
        public float manaCost;
        public SkillEffectBehaviour[] effects; // the effects this skill applies when used
        public TargetLane targetLane; // the lane this skill targets when used
        public TargetPosition targetPosition; // the position in the lane this skill targets when used
        public TargetSide targetSide; // the side this skill targets when used
    }
}
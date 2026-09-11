using UnityEngine;
using Enums;

namespace _Project.Scripts.Data.Definitions
{
    [CreateAssetMenu(fileName = "NewEnemy", menuName = "Blakewynn/Enemy Definition")]
    public class EnemyDefinition : ScriptableObject
    {
        [Header("Identity")]
        public string enemyId;      // stable unique key, e.g. "footsoldier"
        public string displayName;
        [TextArea] public string flavorText;
        public Sprite portrait;

        [Header("Base Stats")]
        public float baseHealth;
        public float baseDps;
        public float baseAttackSpeed;   // seconds per attack

        [Header("Skills")]
        public SkillDefinition[] skills;   // each skill has its own cooldown + mana cost
    }
}
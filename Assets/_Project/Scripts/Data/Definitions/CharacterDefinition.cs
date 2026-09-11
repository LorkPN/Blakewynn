using UnityEngine;
using Enums;

namespace _Project.Scripts.Data.Definitions
{
    // [CreateAssetMenu] lets you right-click in the Project window and create
    // instances of this as .asset files — that's how designers (you) author
    // each character without touching code.
    [CreateAssetMenu(fileName = "NewCharacter", menuName = "Blakewynn/Character Definition")]
    public class CharacterDefinition : ScriptableObject
    {
        [Header("Identity")]
        public string characterId;      // stable unique key, e.g. "knight_aldric" — use this for save data, NOT the display name
        public string displayName;
        [TextArea] public string flavorText;
        public Sprite portrait;

        [Header("Classification")]
        public Rarity rarity;
        public CharacterClass characterClass;   // determines gear compatibility
        public Race race;
        public FactionDefinition faction;

        [Header("Base Stats")]
        public float baseHealth;
        public float baseDps;
        public float baseAttackSpeed;   // seconds per attack

        [Header("Skills")]
        public SkillDefinition[] skills;   // each skill has its own cooldown + mana cost

        [Header("Idle Contribution")]
        public float baseIdleDpsContribution;  // starting point before idle-layer investment
    }
}
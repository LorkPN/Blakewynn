using UnityEngine;
using _Project.Scripts.Data.Enums;


namespace _Project.Scripts.Data.Definitions
{
    [CreateAssetMenu(fileName = "NewClass", menuName = "Blakewynn/Character Class")]
    public class CharacterClass : ScriptableObject
    {
        [Header("Identity")]
        public string classId;       // stable key, e.g. "class_knight" — same reasoning as characterId
        public string displayName;   // "Knight"
        [TextArea] public string description;
        public Sprite classIcon;

        [Header("Gear Compatibility")]
        // The specific gear TYPES this class can equip — e.g. a Knight might allow
        // [Sword, Shield, Heavy Armor, Amulet] while a Rogue allows [Dagger, Light Armor, Cloak, Amulet].
        // GearType is a small enum (see below) shared across all classes, so two classes
        // can overlap on some slots (both equip Amulet) while differing on others.
        public GearType[] equippableGearTypes;
    }
}
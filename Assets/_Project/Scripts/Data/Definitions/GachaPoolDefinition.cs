using UnityEngine;
using Enums;
using Runtime;


namespace _Project.Scripts.Data.Definitions
{
    [CreateAssetMenu(fileName = "NewGachaPool", menuName = "Blakewynn/Gacha Pool")]
    public class GachaPoolDefinition : ScriptableObject
    {
        [Header("Identity")]
        public string poolId;        // stable key, e.g. "gacha_pool_01" — same reasoning as characterId
        public string displayName;   // "Gacha Pool 01"
        [TextArea] public string description;
        public Sprite poolIcon;

        [Header("Gacha Mechanics")]
        public GachaPoolEntry[] entries; // the entries in this gacha pool, each with its own weight and rarity
    }
}
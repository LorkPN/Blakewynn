using UnityEngine;
using Assets._Project.Scripts.Data.Definitions;


namespace Assets._Project.Scripts.Registries
{
    [CreateAssetMenu(fileName = "GameDatabase", menuName = "Blakewynn/Game Database")]
    public class GameDatabase : ScriptableObject
    {
        public CharacterDefinition[] characters;
        public GearDefinition[] gear;
        public FactionDefinition[] factions;
        public EnemyDefinition[] enemies;
        public CharacterClass[] classes;
        public SkillDefinition[] skills;
    }
}
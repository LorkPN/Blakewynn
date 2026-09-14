using UnityEngine;


namespace Assets._Project.Scripts.Data.Definitions
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
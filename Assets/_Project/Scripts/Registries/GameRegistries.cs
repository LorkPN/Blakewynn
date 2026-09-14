using Assets._Project.Scripts.Data.Definitions;


namespace Assets._Project.Scripts.Registries
{
    public static class GameRegistries
    {
        public static Registry<CharacterDefinition> Characters { get; } = new();
        public static Registry<GearDefinition> Gear { get; } = new();
        public static Registry<FactionDefinition> Factions { get; } = new();
        public static Registry<EnemyDefinition> Enemies { get; } = new();
        public static Registry<CharacterClass> Classes { get; } = new();
        public static SkillRegistry Skills { get; } = new();

        public static void Initialize(GameDatabase database)
        {
            foreach (var character in database.characters) Characters.Register(character.characterId, character);
            foreach (var gear in database.gear) Gear.Register(gear.gearId, gear);
            foreach (var faction in database.factions) Factions.Register(faction.factionId, faction);
            foreach (var enemy in database.enemies) Enemies.Register(enemy.enemyId, enemy);
            foreach (var characterClass in database.classes) Classes.Register(characterClass.classId, characterClass);
            foreach (var skill in database.skills) Skills.Register(skill);
        }
    }
} 
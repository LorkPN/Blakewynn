using Assets._Project.Scripts.Data.Definitions;
using Assets._Project.Scripts.Data.Runtime;
using Assets._Project.Scripts.Data.Enums;


namespace Assets._Project.Scripts.Systems.Combat
{
    // One character actively participating in the current battle.
    // Wraps the persistent OwnedCharacter, but everything here is
    // transient — created when combat starts, discarded when it ends.
    public class CombatUnit
    {
        public OwnedCharacter source;          // persistent record — read from, never mutated mid-combat
        public CharacterDefinition definition; // resolved via registry — base stats, skills, etc.

        public float currentHealth;
        public int lane;                       // formation position — exact representation still TBD
        public bool isAlive => currentHealth > 0f;
        public Team team;                       // which side this unit is on

        // cooldown timers, active buffs/debuffs, etc. will live here as combat gets built out
    }
}
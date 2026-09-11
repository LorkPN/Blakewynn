namespace _Project.Scripts.Data.Enums
{
    public enum CharacterStat
    {
        Health, // the character's maximum health
        Strength, // the character's base damage per attack
        Dexterity, // the character's attack speed, higher numbers translate to faster attacks
        Luck, // the chance that an attack will be a critical hit, expressed as a percentage, percents over 100% will cause double crits, triple crits, etc.
        Precision, // the multiplier applied to damage when a critical hit occurs (e.g., 2.0 for double damage)
        Armor, // the character's damage reduction from physical attacks, used as a flat reduction
        MagicResistance, // the character's damage reduction from magical attacks, used as a flat reduction
        Wisdom, // how much the character contributes to the group mana regeneration in mana regenerated per second
        Vitality, // how much health the character regenerates per second
        Intelligence, // damage scaling for magical attacks, used as a multiplier on base damage
    }
}
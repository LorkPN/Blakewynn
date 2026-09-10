using System;
using System.Collections.Generic;

[Serializable]
public class SaveData
{
    public OwnedGearInstance[] ownedGears;
    public OwnedCharacter[] unlockedCharacters;
    public HashSet<string> clearedLevels; // levelId strings
    public int idleFloor; // the highest floor the player has reached in the idle dungeon
    public int silver; // the player's current silver balance
    public int gold; // the player's current gold balance
}
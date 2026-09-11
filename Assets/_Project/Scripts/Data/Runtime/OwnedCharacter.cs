using System;
using System.Collections.Generic;
using UnityEngine;


namespace _Project.Scripts.Data.Runtime
{
    [Serializable]
    public class OwnedCharacter
    {
        // Links back to the ScriptableObject via the registry lookup —
        // NOT a direct reference (see note below on why).
        public string characterId;

        [Header("Shared Core Progression")]
        public int level;
        public int rarityDupeCount;   // extra copies pulled past the first — common gacha mechanic for incremental power

        [Header("Active Layer")]
        public GearSlot[] gearSlots;       // fixed size 4, per the doc
        public string[] equippedSkillIds;  // if you ever let players choose which skills are "active," otherwise skip this

        [Header("Idle Layer")]
        public float idleInvestmentStat;   // separate multiplier boosting this character's idle-DPS contribution

        [Header("Meta")]
        public DateTime acquiredAt;        // handy for "sort by newest," collection stats, etc.

        // Constructor for when a new pull happens
        public OwnedCharacter(string characterId)
        {
            this.characterId = characterId;
            level = 1;
            rarityDupeCount = 0;
            gearSlots = new GearSlot[4];
            idleInvestmentStat = 0f;
            acquiredAt = DateTime.UtcNow;
        }
    }

    [Serializable]
    public struct GearSlot
    {
        public string equippedGearInstanceId;  // empty/null if nothing equipped
    }
}
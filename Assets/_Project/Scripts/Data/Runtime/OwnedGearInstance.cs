using System;
using UnityEngine;
using Assets._Project.Scripts.Systems.Combat;


namespace Assets._Project.Scripts.Data.Runtime
{
    [Serializable]
    public class OwnedGearInstance
    {
        // Links back to the ScriptableObject via the registry lookup —
        // NOT a direct reference (see note below on why).
        public string gearId;

        [Header("Shared Core Progression")]
        public int level;

        [Header("Active Layer")]
        public GearEffect[] statEffects;
        public GearEffectBehaviour[] complexEffects;

        [Header("Idle Layer")]
        public float idleDpsBoost;   // separate multiplier boosting this gear's idle-DPS contribution

        [Header("Meta")]
        public DateTime acquiredAt;        // handy for "sort by newest," collection stats, etc.

        // Constructor for when a new pull happens
        public OwnedGearInstance(string gearId, int statEffectCount, int complexEffectCount)
        {
            this.gearId = gearId;
            level = 1;
            statEffects = new GearEffect[statEffectCount];
            complexEffects = new GearEffectBehaviour[complexEffectCount];
            idleDpsBoost = 0f;
            acquiredAt = DateTime.UtcNow;
        }
    }
}
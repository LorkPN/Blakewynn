using System;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class OwnedGearInstance
{
    // Links back to the ScriptableObject via the registry lookup —
    // NOT a direct reference (see note below on why).
    public string gearId;

    [Header("Shared Core Progression")]
    public int level;

    [Header("Active Layer")]
    public GearEffect[] effects;

    [Header("Idle Layer")]
    public float idleDpsBoost;   // separate multiplier boosting this gear's idle-DPS contribution

    [Header("Meta")]
    public DateTime acquiredAt;        // handy for "sort by newest," collection stats, etc.

    // Constructor for when a new pull happens
    public OwnedGearInstance(string gearId, int effectCount)
    {
        this.gearId = gearId;
        level = 1;
        effects = new GearEffect[effectCount];
        idleDpsBoost = 0f;
        acquiredAt = DateTime.UtcNow;
    }
}
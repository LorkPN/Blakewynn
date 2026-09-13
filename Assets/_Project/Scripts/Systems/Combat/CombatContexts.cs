using System.Collections.Generic;
using Assets._Project.Scripts.Data.Definitions;
using Assets._Project.Scripts.Data.Enums;

namespace Assets._Project.Scripts.Systems.Combat
{
    // Fired when a skill activates. Two different hooks read this same context:
    // - OnActivation fires only on the effects attached to the skill being used.
    // - OnSkillActivated is a broadcast — every OTHER equipped effect (gear or
    //   other skills) also sees it, for synergy effects like "using skill 1
    //   refreshes skill 2's cooldown."
    public class SkillActivationContext
    {
        public CombatUnit caster;
        public SkillDefinition skill;
        public TargetLane resolvedTargetLane;    // mutable — a behavior can override the skill's default
        public TargetPosition resolvedTargetPosition; // mutable — a behavior can override the skill's default
        public CombatState combatState; // the current state of the fight, including both sides' formations
        public TargetSide targetSide; // mutable — a behavior can override the skill's default
        public List<CombatUnit> resolvedTargets; // filled in by the targeting step, mutable by hooks
        public bool cancelled;                   // set true to veto activation entirely (e.g. a Disable effect)
    }

    public class SkillDeactivationContext
    {
        public CombatUnit caster;
        public SkillDefinition skill;
    }

    public class CombatTickContext
    {
        public float deltaTime;
        public List<CombatUnit> allUnits;   // everyone currently in the fight, both sides
    }

    public class DamageContext
    {
        public CombatUnit source;   // who dealt the damage
        public CombatUnit target;   // who received it
        public float amount;        // mutable — hooks can modify before it's actually applied
        public bool isCritical;
    }

    public class CharacterDeathContext
    {
        public CombatUnit unit;
    }

    public class WaveStartContext
    {
        public int waveNumber;
        public List<CombatUnit> enemies;
    }

    public class WaveEndContext
    {
        public int waveNumber;
    }
}
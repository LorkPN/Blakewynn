using UnityEngine;


namespace Assets._Project.Scripts.Systems.Combat
{
    // Base class for combat-driven effects. Each concrete effect is its own
    // ScriptableObject asset — you create a new .cs class per distinct behavior,
    // override only the hooks it actually cares about, and drop the resulting
    // asset into a CombatDefinition's effects list.
    public abstract class CombatEffectBehaviour : ScriptableObject
    {
        public virtual void OnActivation(SkillActivationContext ctx) { }
        public virtual void OnDeactivation(SkillDeactivationContext ctx) { }
        public virtual void OnSkillActivated(SkillActivationContext ctx) { }
        public virtual void OnCombatTick(CombatTickContext ctx) { }
        public virtual void OnDamageDealt(DamageContext ctx) { }
        public virtual void OnDamageTaken(DamageContext ctx) { }
        public virtual void OnCharacterDeath(CharacterDeathContext ctx) { }
        public virtual void OnWaveStart(WaveStartContext ctx) { }
        public virtual void OnWaveEnd(WaveEndContext ctx) { }
    }
}
namespace Assets._Project.Scripts.Systems.Combat
{
    // Base class for skill-driven effects. Each concrete effect is its own
    // ScriptableObject asset — you create a new .cs class per distinct behavior,
    // override only the hooks it actually cares about, and drop the resulting
    // asset into a SkillDefinition's effects list.
    public abstract class SkillEffectBehaviour : CombatEffectBehaviour
    {
        
    }
}
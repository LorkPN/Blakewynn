namespace Assets._Project.Scripts.Systems
{
    // Base class for gear-driven behavior. Each concrete effect is its own
    // ScriptableObject asset — you create a new .cs class per distinct behavior,
    // override only the hooks it actually cares about, and drop the resulting
    // asset into a GearDefinition's effects list.
    public abstract class GearEffectBehaviour : CombatEffectBehaviour
    {
        
    }
}
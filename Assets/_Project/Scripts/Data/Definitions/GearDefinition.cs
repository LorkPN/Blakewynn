using UnityEngine;
using _Project.Scripts.Data.Enums;


[CreateAssetMenu(fileName = "GearDefinition", menuName = "Definitions/Gear")]
public class GearDefinition : ScriptableObject
{
    [Header("Identity")]
    public string gearId;        // stable key, e.g. "gear_sword_01" — same reasoning as characterId
    public string displayName;   // "Sword of the Brave"
    [TextArea] public string description;
    public Sprite gearIcon;
    public GearTier gearTier;          // common, uncommon, rare, epic, legendary, etc. — see GearTier enum

    [Header("Gear Type")]
    public GearType gearType;    // the type of gear this is — see GearType enum

    [Header("Stats")]
    public BuffDefinition[] buffs; // the buffs this gear applies when equipped
    public int level;
}
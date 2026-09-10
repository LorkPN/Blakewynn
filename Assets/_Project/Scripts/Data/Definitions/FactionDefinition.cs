using UnityEngine;

[CreateAssetMenu(fileName = "NewFaction", menuName = "Blakewynn/Faction Definition")]
public class FactionDefinition : ScriptableObject
{
    [Header("Identity")]
    public string factionId;
    public string displayName; 
    [TextArea] public string description;
    public Sprite factionIcon;
    public BuffDefinition[] factionBuffs; // buffs that apply to all members of this faction
}
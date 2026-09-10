using UnityEngine;

[CreateAssetMenu(fileName = "IdleFloorDefinition", menuName = "Definitions/IdleFloor")]
public class IdleFloorDefinition : ScriptableObject
{
    [Header("Identity")]
    public string floorId;        // stable key, e.g. "floor_01" — same reasoning as characterId
    public Sprite floorIcon;

    [Header("Gameplay")]
    public int level;
    [Header("Rewards")]
    public GearDefinition[] potentialGear;
    public int silverReward;
    public int firstTimeSilverReward; // the silver reward for completing this floor for the first time
}
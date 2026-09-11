using UnityEngine;


namespace _Project.Scripts.Data.Definitions
{
    [CreateAssetMenu(fileName = "ActiveFloorDefinition", menuName = "Definitions/ActiveFloor")]
    public class ActiveFloorDefinition : ScriptableObject
    {
        [Header("Identity")]
        public string floorId;        // stable key, e.g. "floor_01" — same reasoning as characterId
        public string displayName;   // "The Forgotten Crypt"
        [TextArea] public string description;
        public Sprite floorIcon;

        [Header("Gameplay")]
        public int level;

        public EnemyDefinition[] enemies; // the enemies that will be included in this floor
        public int waves;
        [Header("Rewards")]
        public GearDefinition[] potentialGear;
        public int goldReward;
        public int firstTimeGoldReward; // the gold reward for completing this floor for the first time
    }
}
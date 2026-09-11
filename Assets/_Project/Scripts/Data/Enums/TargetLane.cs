namespace _Project.Scripts.Data.Enums
{
    public enum TargetLane
    {
        CurrentLane, // the lane the character is currently in,
        AdjacentLanes, // the lanes next to the character's current lane
        AllLanes, // all lanes, including the character's current lane
        RandomLane, // a random lane, including the character's current lane
        RandomAdjacentLane, // a random lane next to the character's current lane
        AllExceptCurrentLane, // all lanes except the character's current lane
    }
}
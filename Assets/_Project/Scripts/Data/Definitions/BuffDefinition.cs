using UnityEngine;


[CreateAssetMenu(fileName = "NewBuff", menuName = "Blakewynn/Buff Definition")]
public class BuffDefinition : ScriptableObject
{
    [Header("Identity")]
    public string buffId;
    public string displayName;
    [TextArea] public string description;
    public Sprite buffIcon;
}
using UnityEngine;

[CreateAssetMenu(fileName = "NewEffect", menuName = "Blakewynn/Effect Definition")]
public class EffectDefinition : ScriptableObject
{
    [Header("Identity")]
    public string effectId;
    public string displayName;
    [TextArea] public string description;
    public Sprite effectIcon;
}
using UnityEngine;


[CreateAssetMenu(fileName = "NewSkill", menuName = "Blakewynn/Skill Definition")]
public class SkillDefinition : ScriptableObject
{
    [Header("Identity")]
    public string skillId;
    public string displayName;
    [TextArea] public string description;
    public Sprite skillIcon;
}

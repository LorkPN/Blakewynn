using UnityEngine;


[CreateAssetMenu(fileName = "NewSkill", menuName = "Blakewynn/Skill Definition")]
public class SkillDefinition : ScriptableObject
{
    [Header("Identity")]
    public string skillId;
    public string displayName;
    [TextArea] public string description;
    public Sprite skillIcon;
    public float cooldown; // seconds
    public float manaCost; // how much mana this skill consumes when used
    public EffectDefinition[] effects; // the effects this skill applies when used
    public int level;
}

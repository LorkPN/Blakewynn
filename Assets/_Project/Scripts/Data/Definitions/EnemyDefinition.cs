using UnityEngine;
using _Project.Scripts.Data.Enums;

[CreateAssetMenu(fileName = "NewEnemy", menuName = "Blakewynn/Enemy Definition")]
public class EnemyDefinition : ScriptableObject
{
    [Header("Identity")]
    public string characterId;      // stable unique key, e.g. "knight_aldric" — use this for save data, NOT the display name
    public string displayName;
    [TextArea] public string flavorText;
    public Sprite portrait;

    [Header("Base Stats")]
    public float baseHealth;
    public float baseDps;
    public float baseAttackSpeed;   // seconds per attack

    [Header("Skills")]
    public SkillDefinition[] skills;   // each skill has its own cooldown + mana cost
}
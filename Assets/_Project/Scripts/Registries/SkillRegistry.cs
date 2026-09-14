using UnityEngine;
using System.Collections.Generic;
using Assets._Project.Scripts.Data.Definitions;

namespace Assets._Project.Scripts.Registries
{
    public class SkillRegistry
    {
        private readonly Dictionary<string, Dictionary  <int, SkillDefinition>> _lookup = new();

        public void Register(SkillDefinition skill)
        {
            if (!_lookup.TryGetValue(skill.skillLineId, out var levels))
            {
                levels = new Dictionary<int, SkillDefinition>();
                _lookup[skill.skillLineId] = levels;
            }
            levels[skill.level] = skill;
        }

        public SkillDefinition Get(string skillLineId, int level)
        {
            if (_lookup.TryGetValue(skillLineId, out var levels) && levels.TryGetValue(level, out var skill))
            {
                return skill;
            }
            Debug.LogWarning($"SkillRegistry does not contain an entry for '{skillLineId}' at level {level}. Returning null.");
            return null;
        }
    }
}
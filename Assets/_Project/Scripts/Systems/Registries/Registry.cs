using UnityEngine;
using System.Collections.Generic;

namespace Assets._Project.Scripts.Systems.Registries
{
    public class Registry<T>
    {
        private Dictionary<string, T> _lookup = new();

        public void Register(string id, T value)
        {
            if (_lookup.ContainsKey(id))
            {
                Debug.LogWarning($"Registry already contains an entry for '{id}'. Overwriting value.");
            }
            _lookup[id] = value;
        }

        public T Get(string id)
        {
            if (_lookup.TryGetValue(id, out T value))
            {
                return value;
            }
            Debug.LogWarning($"Registry does not contain an entry for '{id}'. Returning default value.");
            return default;
        }

        public bool TryGet(string id, out T value) => _lookup.TryGetValue(id, out value);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Loki.Weapon.Base {
    [CreateAssetMenu(fileName = "BulletConfig", menuName = "Loki/BulletConfig", order = 0)]
    public class ProjectileConfig : ScriptableObject {
        // Damage
        [field: SerializeField] public Vector2Int DamageRange { get; private set; }

        // Speed
        [field: SerializeField] public float Speed { get; private set; }
    }
}

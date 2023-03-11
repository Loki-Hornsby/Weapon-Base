using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Loki.Weapon.Base {
    [CreateAssetMenu(fileName = "BulletConfig", menuName = "Loki/BulletConfig", order = 0)]
    public class ProjectileConfig : ScriptableObject {
        // Damage
        [field: SerializeField] public Vector2Int DamageRange { get; private set; }

        public int GetDamage(){
            return Random.Range(DamageRange.x, DamageRange.y);
        }

        // Speed
        [field: SerializeField] public float Speed { get; private set; }

        // Spread
        [field: SerializeField] public float Spread { get; private set; }

        public Vector3 GetSpread(){
            return new Vector3(
                Random.Range(-Spread, Spread),
                Random.Range(-Spread, Spread),
                Random.Range(-Spread, Spread)
            );
        }
    }
}

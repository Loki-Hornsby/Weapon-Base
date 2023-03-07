using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Loki.Weapon.Base {
    [CreateAssetMenu(fileName = "WeaponConfig", menuName = "Loki/WeaponConfig", order = 0)]
    public class WeaponConfig : ScriptableObject {
        // Bullet
        [field: SerializeField] public GameObject Bullet { get; private set; }

        // Uses
        [field: SerializeField] public int StartingUses { get; private set; }
    }
}
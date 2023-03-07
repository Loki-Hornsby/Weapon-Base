using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Loki.Weapon.Base {
    public class Weapon : MonoBehaviour {
        // Config
        public WeaponConfig config;

        // Local Variables
        int uses;

        /// <summary>
        /// Initialize our weapon
        /// </summary>
        void Start(){
            uses = config.StartingUses;
        }

        /// <summary>
        /// use our weapon
        /// </summary>
        public void Use(){
            // Reduce uses
            uses--;

            // If it still has uses
            if (uses > 0){
                // If our weapon has a projectile prefab defined (if it isn't a melee weapon)
                if (config.Bullet != null){
                    // Spawn a projectile and propel it
                    Instantiate(config.Bullet).GetComponent<Projectile>().Propel();
                }

                // Play animation
            } else {
                //config.Break();
            }
        }
    }
}
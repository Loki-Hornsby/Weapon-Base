using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Loki.Weapon.Base {
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Collider))]
    public class Projectile : MonoBehaviour {
        public ProjectileConfig config;

        Rigidbody rb;
        bool active;

        public void Activate(){
            // Get rigidbody
            rb = GetComponent<Rigidbody>();

            // Propel projectile forward
            rb.AddForce(transform.forward * config.Speed, ForceMode.Impulse);

            active = true;
        }

        private void OnCollisionEnter(Collision other) {
            // Get the spread of the bullet
            Vector3 spread = config.GetSpread();

            // Apply spread
            rb.AddForce(spread, ForceMode.Impulse);

            // Send hit message
            other.gameObject.SendMessage("TriggerHit", this, SendMessageOptions.DontRequireReceiver);
        }

        private void OnCollisionExit(Collision other) {
            
        }
    }
}
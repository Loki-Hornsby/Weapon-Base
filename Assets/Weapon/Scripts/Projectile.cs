using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Loki.Weapon.Base {
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Collider))]
    public class Projectile : MonoBehaviour {
        public ProjectileConfig config;
        [System.NonSerialized] public Rigidbody rb;
        [System.NonSerialized] public Collider col;

        void Start(){
            rb = GetComponent<Rigidbody>();
            col = GetComponent<Collider>();
        }

        public void Propel(){
            rb.AddForce(transform.forward * config.Speed, ForceMode.Impulse);
        }

        private void OnCollisionEnter(Collision other) {
            Debug.Log("Enter");
        }

        private void OnCollisionExit(Collision other) {
            Debug.Log("Exit");
        }
    }
}

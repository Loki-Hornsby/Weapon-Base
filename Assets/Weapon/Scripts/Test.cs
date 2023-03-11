using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Loki.Weapon.Base {
    public class Test : MonoBehaviour {
        public Weapon weapon;
        public HitReceiver Enemy1;
        public HitReceiver Enemy2;

        void Hit(HitData data){
            data.invoker.gameObject.GetComponent<MeshRenderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }

        void Start(){
            Enemy1.Hit += Hit;
            Enemy2.Hit += Hit;
        }

        void Update(){
            if (Input.GetMouseButtonDown(0)){
                weapon.Use();
            }
        }
    }
}
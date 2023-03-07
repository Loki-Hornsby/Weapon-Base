using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Loki.Weapon.Base {
    public class Test : MonoBehaviour {
        public Weapon weapon;

        void Update(){
            if (Input.GetMouseButtonDown(0)){
                weapon.Use();
            }
        }
    }
}
/// <summary>
/// Made by Loki Alexander Button Hornsby
/// Licensed under the BSD 3-Clause "New" or "Revised" License
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Loki.Weapon.Base {
    public class HitData {
        // Source projectile
        public Projectile invoker;

        public HitData(Projectile proj){
            // Define what invoked this hit call
            invoker = proj;
        }
    }

    public class HitReceiver : MonoBehaviour{
        // Hit Event
        public delegate void HitEvent(HitData data);
        public event HitEvent Hit;

        // Trigger hit event
        public void TriggerHit(Projectile proj){
            // Trigger hit event and pass a new hit data class
            Hit?.Invoke(new HitData(proj));
        }
    }
}
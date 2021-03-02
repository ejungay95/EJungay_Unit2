using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour {
  private void OnTriggerEnter(Collider other) {
    // Unintended feature when two animals collide, they are destroyed rather than from the projectile

    // Changed to only destroy when projectile hits animal
    if(other.gameObject.CompareTag("Projectile")) {
      Destroy(other.gameObject);
      Destroy(gameObject);
    }
  }
}

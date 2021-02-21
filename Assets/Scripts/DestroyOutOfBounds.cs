using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour {
  private float topOfScreen = 30.0f;
  private float bottomOfScreen = -10.0f;

  // Start is called before the first frame update
  void Start() {
        
  }

  // Update is called once per frame
  void Update() {
    if(transform.position.z > topOfScreen) {
      Destroy(gameObject);
    } else if(transform.position.z < bottomOfScreen) {
      Destroy(gameObject);
    }
  }
}

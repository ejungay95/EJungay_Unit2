using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
  private float xRange = 15f;
  public GameObject[] animalPrefabs;

  // Start is called before the first frame update
  void Start() {
        
  }

  // Update is called once per frame
  void Update() {
    if(Input.GetKeyDown(KeyCode.A)) {
      float randXPos = Random.Range(-xRange, xRange);
      int animalPrefabIndex = Random.Range(0, animalPrefabs.Length);
      Vector3 randPos = new Vector3(randXPos, 0, 21);
      Instantiate(animalPrefabs[animalPrefabIndex], randPos, animalPrefabs[animalPrefabIndex].transform.rotation);
    }
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	[SerializeField] private GameObject cubePrefab;
	private GameObject enemy;

	void Update () {
		if (enemy == null) {
			
			//random position within the central area of the stage where the enemy will be spawned
			Vector3 rndPosition = new Vector3(Random.Range(10f, 20f), 5f, Random.Range(-19f, 2f));

			enemy = Instantiate(cubePrefab,rndPosition,Quaternion.Euler(new Vector3(0f,0f,0f)));
		}
	}
}

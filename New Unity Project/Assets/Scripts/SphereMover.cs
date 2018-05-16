using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMover : MonoBehaviour {

	[SerializeField] private float speed = 2f;
		
	void Update () {
		transform.Translate (0f, 0f, 5f * speed * Time.deltaTime);
	}
}

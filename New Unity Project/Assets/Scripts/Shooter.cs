using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

	private Camera cam;
	[SerializeField] private GameObject spherePrefab;
	private GameObject bullet;

	void Start() {
		cam = GetComponent<Camera> ();

		//hide the mouse cursor
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			bullet = Instantiate (spherePrefab, cam.transform.position, cam.transform.rotation);
		}
	}

	//create a "+" aiming indicator at the center of the screen
	void OnGUI() {
		int size = 22;
		float posX = cam.pixelWidth/2 - size/4;
		float posY = cam.pixelHeight/2 - size/2;
		GUI.Label(new Rect(posX, posY, size, size), "+");
	}
}

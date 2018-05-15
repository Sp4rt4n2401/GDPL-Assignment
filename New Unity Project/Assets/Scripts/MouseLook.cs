using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

	public enum RotationAxex { 
		MouseX = 0, 
		MouseY = 1 
	} 

	public RotationAxex axis = RotationAxex.MouseX;

	public float sensitivityHor = 9.0f; 
	public float sensitivityVer = 9.0f;

	private float rotationX = 0f; 

	public float minimumVer = -45.0f;
	public float maximumVer = 45.0f; 


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (axis == RotationAxex.MouseX) { 
			transform.Rotate (0, Input.GetAxis("Mouse X") * sensitivityHor, 0); 
		}
		else {
			rotationX -= Input.GetAxis ("Mouse Y") * sensitivityVer;
			rotationX = Mathf.Clamp (rotationX, minimumVer, maximumVer); 
			float rotationY = transform.localEulerAngles.y;
			transform.localEulerAngles = new Vector3 (rotationX, rotationY, 0);
		} 

	}
}

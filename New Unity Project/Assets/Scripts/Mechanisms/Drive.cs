using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public float rSpeed;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Button.buttonQuery)
        {
            gameObject.transform.Translate(0, 0, rSpeed);

            if(gameObject.transform.position.z > 50)
            {
                rSpeed = 0;
            }
        }
	}
}

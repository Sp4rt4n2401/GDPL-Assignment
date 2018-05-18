using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonBehaviour : MonoBehaviour
{
    public float rSpeed = 0;
    public GameObject piston;
	// Use this for initialization

	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        piston = GameObject.FindGameObjectWithTag("Piston");
        if(Bunce.collisionCheck)
        {
            gameObject.transform.Translate(0, rSpeed, 0);

            if ((gameObject.transform.position.x) > 1.5)
            {
                rSpeed = 0;
            }
        }
    }
}

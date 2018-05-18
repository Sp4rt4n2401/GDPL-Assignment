using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCollision : MonoBehaviour
{
    public static bool collisionCheck = false;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter(Collision col)
    {
        collisionCheck = true;
    }

}

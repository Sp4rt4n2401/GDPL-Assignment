using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBall : MonoBehaviour
{
    public float rSpeed = 0;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (LastPush.collisionCheck)
        {
            gameObject.transform.Translate(0, 0, rSpeed * Time.deltaTime);

            if (gameObject.transform.position.z > 13)
            {
                rSpeed = 0;
            }
        }
    }
}

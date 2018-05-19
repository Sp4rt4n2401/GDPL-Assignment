using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastPush : MonoBehaviour
{
    public static bool collisionCheck = false;
    public float rSpeed = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider EndTrigger)
    {
        collisionCheck = true;
        //PistonTrigger.transform.Translate(0, rSpeed, 0);
    }
}



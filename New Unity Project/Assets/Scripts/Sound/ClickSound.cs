using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour
{
    public AudioSource click;

    // Use this for initialization
    void Start ()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (ClickCollision.collisionCheck)
        {
            Debug.Log("Collision occured");
            GetComponent<AudioSource>().Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}

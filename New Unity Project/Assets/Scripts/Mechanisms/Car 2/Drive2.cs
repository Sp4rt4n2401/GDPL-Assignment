using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive2 : MonoBehaviour
{
    public float rSpeed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Button2.buttonQuery)
        {
            gameObject.transform.Translate(0, 0, rSpeed * Time.deltaTime);

            if (gameObject.transform.position.z < 35)
            {
                rSpeed = 0;
            }
        }
    }
}
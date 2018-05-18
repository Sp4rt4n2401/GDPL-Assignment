using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive3 : MonoBehaviour
{
    public float rSpeed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Button3.buttonQuery)
        {
            gameObject.transform.Translate(0, 0, rSpeed * Time.deltaTime);

            if (gameObject.transform.position.x > 45)
            {
                rSpeed = 0;
            }
        }
    }
}
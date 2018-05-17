using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner2Rotate : MonoBehaviour
{

    public float rSpeed = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rSpeed, 0);
    }
}

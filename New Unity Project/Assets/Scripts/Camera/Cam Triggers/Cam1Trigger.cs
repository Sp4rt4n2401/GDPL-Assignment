using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam1Trigger : MonoBehaviour
{
    public Camera debug;
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;
    public Camera cam5;
    public Camera cam6;
    public Camera cam7;
    public Camera cam8;
    public Camera cam9;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        debug.enabled = false;
        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
        cam4.enabled = false;
        cam5.enabled = false;
        cam6.enabled = false;
        cam7.enabled = false;
        cam8.enabled = false;
        cam9.enabled = false;
    }
}

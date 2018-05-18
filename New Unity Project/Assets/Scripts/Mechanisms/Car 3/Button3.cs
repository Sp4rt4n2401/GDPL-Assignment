using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button3 : MonoBehaviour
{
    public static bool buttonQuery = false;
    public Material m_material;
    // Use this for initialization
    void Start()
    {
        m_material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider Switch)
    {
        buttonQuery = true;
        m_material.color = Color.green;
        //PistonTrigger.transform.Translate(0, rSpeed, 0);
    }
}

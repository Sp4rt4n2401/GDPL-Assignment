using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMachine : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        SceneManager.LoadScene("TheMachine", LoadSceneMode.Additive);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}

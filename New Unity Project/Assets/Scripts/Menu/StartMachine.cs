using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMachine : MonoBehaviour {

    public GameObject StartTrigger;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollsion(Collision col)
    {
        if(col.gameObject.name.Contains("StartTrigger"))
        {
            SceneManager.LoadScene("TheMachine", LoadSceneMode.Additive);
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("TheMachine"));
            SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("MainMenu"));
        }
    }
}

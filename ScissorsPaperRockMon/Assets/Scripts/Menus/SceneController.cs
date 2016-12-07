using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void World()
    {
        //Loads level
        Application.LoadLevel("World");
    }

    public void Credits()
    {
        //Loads the Credits
        Application.LoadLevel("Credits");
    }

    public void Quit()
    {
        //Quits Game
        Application.Quit();
    }

    public void Controls()
    {
        //Loads scene that displays the controls
        Application.LoadLevel("Controls");
    }
}

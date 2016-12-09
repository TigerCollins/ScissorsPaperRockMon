using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {

    //Audio
    public AudioSource ButtonPress;

    //Overworld
    public Transform OverWorld;
    public GameObject OverWorldObject;

    // Use this for initialization
    void Start ()
    {
        ButtonPress = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void World()
    {
        //Loads level
        ButtonPress.Play();
        Application.LoadLevel("World");
    }

    public void Credits()
    {
        //Loads the Credits
        ButtonPress.Play();
        Application.LoadLevel("Credits");
    }

    public void Menu()
    {
        //Loads the Credits
        ButtonPress.Play();
        Application.LoadLevel("Menu");
    }

    public void Quit()
    {
        //Quits Game
        ButtonPress.Play();
        Application.Quit();
    }

    public void Controls()
    {
        //Loads scene that displays the controls
        ButtonPress.Play();
        Application.LoadLevel("Controls");
    }
}

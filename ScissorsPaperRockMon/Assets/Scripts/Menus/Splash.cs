using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {

    //Audio
    public AudioSource ButtonPress;

    // Use this for initialization
    void Start ()
    {
        ButtonPress = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.anyKey)
        {
            Application.LoadLevel("Menu");
            ButtonPress.Play();
            print("pressed");
        }

    }
}

using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {

    //Pause Menu
    public GameObject pauseMenu;

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
        
            Pause();
	}

    public void Pause()
    {
        //Brings up Pause Menu
        if (Input.GetKey(KeyCode.Escape))
        {
            if (pauseMenu.activeInHierarchy == false)
            {
                ButtonPress.Play();
            }
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void World()
    {
        //Continues the game
        Time.timeScale = 1;
        ButtonPress.Play();
        pauseMenu.SetActive(false);        
    }

    public void Credits()
    {
        //Loads the Credits
        Time.timeScale = 1;
        ButtonPress.Play();
        Application.LoadLevel("Credits");
    }

    public void Quit()
    {
        //Quits Game to menu
        Time.timeScale = 1;
        ButtonPress.Play();
        Application.LoadLevel("Menu");

    }

    public void Controls()
    {
        //Loads scene that displays the controls
        Time.timeScale = 1;
        ButtonPress.Play();
        Application.LoadLevel("Controls");
    }
}

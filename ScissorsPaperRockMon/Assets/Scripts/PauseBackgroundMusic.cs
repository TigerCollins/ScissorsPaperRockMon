using UnityEngine;
using System.Collections;

public class PauseBackgroundMusic : MonoBehaviour {

    public AudioSource SoundToPause;
    public int ObjectWithSound;

    // Use this for initialization
	void Start ()
    {
        SoundToPause = GetComponent<AudioSource>(); //Grabs audio file attached to object
    }
	
	// Update is called once per frame
	void Update ()
    {
        ObjectWithSound = GameObject.FindGameObjectsWithTag("BattleMusic").Length; //finds objects with tag
        Pause();
	}

    void Pause()
    {
        if (ObjectWithSound == 1)
        {
            SoundToPause.volume = 0f;
        }

        if (ObjectWithSound == 0)
        {
            SoundToPause.volume = .4f;
        }
    }
}

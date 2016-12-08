using UnityEngine;
using System.Collections;

public class DontDestroyOnLoad : MonoBehaviour {

	void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);

        //Destroys if there is a duplicate.
        DontDestroyOnLoad(this);
        if (FindObjectsOfType(GetType()).Length > 2)
        {
            Destroy(gameObject);
        }
    }
    
    // Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }
}

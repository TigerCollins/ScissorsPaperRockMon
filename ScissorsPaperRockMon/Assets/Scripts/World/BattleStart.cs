using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BattleStart : MonoBehaviour {


    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene("Battle", LoadSceneMode.Single);
                //Camera.SetActive(false);
            }
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

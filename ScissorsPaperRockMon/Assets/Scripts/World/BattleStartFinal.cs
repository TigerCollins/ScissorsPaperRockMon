using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BattleStartFinal : MonoBehaviour {
    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene("BattleFinal", LoadSceneMode.Single);
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

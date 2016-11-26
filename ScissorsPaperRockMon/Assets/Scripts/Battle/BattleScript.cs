using UnityEngine;
using System.Collections;

public class BattleScript : MonoBehaviour {
    public GameObject[] PlayerBattleOptions;
    public int[] BattleOptions;
    int index;

    void Start()
    {
        index = Random.Range(0, BattleOptions.Length);
        print(index);
    }

    void Update()
    {
        
    }

    public void BattleScissors()
    {
        if (PlayerBattleOptions[0].activeInHierarchy == false) //Checks to see if the object is active. If not active...
        {
            PlayerBattleOptions[0].SetActive(true); //... Set as active.
            PlayerBattleOptions[1].SetActive(false); // Disable this in hierarchy
            PlayerBattleOptions[2].SetActive(false); // Disable this in hierarchy
        }
    }

    public void BattlePaper()
    {
        if (PlayerBattleOptions[1].activeInHierarchy == false) //Checks to see if the object is active. If not active...
        {
            PlayerBattleOptions[1].SetActive(true); //... Set as active.
            PlayerBattleOptions[0].SetActive(false); // Disable this in hierarchy
            PlayerBattleOptions[2].SetActive(false); // Disable this in hierarchy
        }
    }

    public void BattleRock()
    {
        if (PlayerBattleOptions[2].activeInHierarchy == false) //Checks to see if the object is active. If not active...
        {
            PlayerBattleOptions[2].SetActive(true); //... Set as active.
            PlayerBattleOptions[0].SetActive(false); // Disable this in hierarchy
            PlayerBattleOptions[1].SetActive(false); // Disable this in hierarchy
        }
    }
}


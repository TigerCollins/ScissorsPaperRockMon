using UnityEngine;
using System.Collections;

public class BattleScript : MonoBehaviour {
    public GameObject[] PlayerBattleOptions;
    public GameObject[] EnemyOptions;
    int index;

    void Start()
    {
        
        print(index);
    }

    void Update()
    {
    }

    public void BattleLoader()
    {
        index = Random.Range(0, EnemyOptions.Length); //Selects a random variable from the Battleoptions Array
        ChampionTrainer();
    }

    public void ScissorsTrainer()
    {      
            EnemyOptions[0].SetActive(true); //... Set as active.
            EnemyOptions[1].SetActive(false); // Disable this in hierarchy
            EnemyOptions[2].SetActive(false); // Disable this in hierarchy
    }

    public void PaperTrainer()
    {
        EnemyOptions[1].SetActive(true); //... Set as active.
        EnemyOptions[0].SetActive(false); // Disable this in hierarchy
        EnemyOptions[2].SetActive(false); // Disable this in hierarchy
    }

    public void RockTrainer()
    {
        EnemyOptions[2].SetActive(true); // Set as active.
        EnemyOptions[0].SetActive(false); // Disable this in hierarchy
        EnemyOptions[1].SetActive(false); // Disable this in hierarchy
    }

    public void ChampionTrainer()
    {
        if (index == 0) //Checks to see if the object is active. If not active...
        {
            EnemyOptions[0].SetActive(true); //... Set as active.
            EnemyOptions[1].SetActive(false); // Disable this in hierarchy
            EnemyOptions[2].SetActive(false); // Disable this in hierarchy
        }

        if (index == 1) //Checks to see if the object is active. If not active...
        {
            EnemyOptions[1].SetActive(true); //... Set as active.
            EnemyOptions[0].SetActive(false); // Disable this in hierarchy
            EnemyOptions[2].SetActive(false); // Disable this in hierarchy
        }

        if (index == 2) //Checks to see if the object is active. If not active...
        {
            EnemyOptions[2].SetActive(true); //... Set as active.
            EnemyOptions[0].SetActive(false); // Disable this in hierarchy
            EnemyOptions[1].SetActive(false); // Disable this in hierarchy
        }
    }

    public void BattleScissors()
    {
        if (PlayerBattleOptions[0].activeInHierarchy == false) //Checks to see if the object is active. If not active...
        {
            PlayerBattleOptions[0].SetActive(true); //... Set as active.
            PlayerBattleOptions[1].SetActive(false); // Disable this in hierarchy
            PlayerBattleOptions[2].SetActive(false); // Disable this in hierarchy
            BattleLoader();
        }
    }

    public void BattlePaper()
    {
        if (PlayerBattleOptions[1].activeInHierarchy == false) //Checks to see if the object is active. If not active...
        {
            PlayerBattleOptions[1].SetActive(true); //... Set as active.
            PlayerBattleOptions[0].SetActive(false); // Disable this in hierarchy
            PlayerBattleOptions[2].SetActive(false); // Disable this in hierarchy
            BattleLoader();
        }
    }

    public void BattleRock()
    {
        if (PlayerBattleOptions[2].activeInHierarchy == false) //Checks to see if the object is active. If not active...
        {
            PlayerBattleOptions[2].SetActive(true); //... Set as active.
            PlayerBattleOptions[0].SetActive(false); // Disable this in hierarchy
            PlayerBattleOptions[1].SetActive(false); // Disable this in hierarchy
            BattleLoader();
        }
    }
}


﻿using UnityEngine;
using System.Collections;

public class BattleScript : MonoBehaviour {
    //Battle Options
    public GameObject[] PlayerBattleOptions;
    public GameObject[] EnemyOptions;
    int index;

    //Other Scripts (Health)
    public GameObject HealthTrigger;

    void Start()
    {
        
        //print(index);
    }

    IEnumerator StopHealthHandler()
    {
        yield return new WaitForSeconds(.01f);
        HealthTrigger.SetActive(false);
    }

    void Update()
    {
        //Selects a random variable from the Battleoptions Array
        index = Random.Range(0, EnemyOptions.Length);
    }

    public void BattleLoader()
    {
        ChampionTrainer();
    }

    public void ScissorsTrainer()
    {
        BattleLoader();
        EnemyOptions[0].SetActive(true); //... Set as active.
        EnemyOptions[1].SetActive(false); // Disable this in hierarchy
        EnemyOptions[2].SetActive(false); // Disable this in hierarchy
    }

    public void PaperTrainer()
    {
        BattleLoader();
        EnemyOptions[1].SetActive(true); //... Set as active.
        EnemyOptions[0].SetActive(false); // Disable this in hierarchy
        EnemyOptions[2].SetActive(false); // Disable this in hierarchy
    }

    public void RockTrainer()
    {
        BattleLoader();
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
            HealthTrigger.SetActive(true);
            StartCoroutine(StopHealthHandler());
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
            HealthTrigger.SetActive(true);
            StartCoroutine(StopHealthHandler());
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
            HealthTrigger.SetActive(true);
            StartCoroutine(StopHealthHandler());
        }
    }
}


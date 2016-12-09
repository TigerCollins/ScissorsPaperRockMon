using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class HealthHandler : MonoBehaviour
{
    public float playerHealth = 8f;
    public float enemyHealth = 8f;

    //UI
    public Image playerHealthSlider;
    public Image enemyHealthSlider;

    //Battle Options
    public GameObject Scissors;
    public GameObject Paper;
    public GameObject Rock;
    public GameObject ScissorsBad;
    public GameObject PaperBad;
    public GameObject RockBad;

    public int HealthTrigger; // Triggers the health updater

    //Destroying scene
    public GameObject Battle;
    public GameObject MainCamera;
    public GameObject OverWorld;

    // Use this for initialization
    void Start()
    {
        
    }

  
    // Update is called once per frame
    void FixedUpdate()
    {
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");//Finds object with Main Camera tag
        HealthTrigger = GameObject.FindGameObjectsWithTag("Health").Length;
        if (HealthTrigger == 1f)
        {
            BattleOutcome();
        }

        BattleOver();
        HealthUI();
    }

    public void BattleOutcome()
    {
        if (Scissors.activeInHierarchy == true)
            {
                if (PaperBad.activeInHierarchy == true)
                {
                    enemyHealth -= 1;
                }
                if (RockBad.activeInHierarchy == true)
                {
                    playerHealth -= 1;
                }
            }

            if (Paper.activeInHierarchy == true)
            {
                if (RockBad.activeInHierarchy == true)
                {
                    enemyHealth -= 1;
                }
                if (ScissorsBad.activeInHierarchy == true)
                {
                    playerHealth -= 1;
                }
            }

            if (Rock.activeInHierarchy == true)
            {
                if (ScissorsBad.activeInHierarchy == true)
                {
                    enemyHealth -= 1;
                }
                if (PaperBad.activeInHierarchy == true)
                {
                    playerHealth -= 1;
                }
            }
        }

    void BattleOver()
    {
        if (playerHealth <= 0)
        {
            Destroy(Battle);
        }

        if (enemyHealth <= 0)
        {
            
            Destroy(Battle);
        }
    }

    void HealthUI()
    {
        playerHealthSlider.fillAmount = playerHealth / 8f;
        enemyHealthSlider.fillAmount = enemyHealth / 8f;
    }
 }

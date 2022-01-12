using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour
{
    public GameObject heart1, heart2, heart3;
    public int playerMaxHealth;
    public int playerCurrentHealth;
    public int deathScene;

    public Animator animator;

    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
    }

    void Update()
    {
        if (playerCurrentHealth <= 0)
        {
            SceneManager.LoadScene(deathScene);
        }

        switch (playerCurrentHealth)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
        }
    }

    public void HurtPlayer(int damageToGive)
    {
        playerCurrentHealth -= damageToGive;
        animator.SetTrigger("Hurt"); 
    }

    public void HealPlayer(int healing)
    {
        playerCurrentHealth += healing;

        if (playerCurrentHealth > playerMaxHealth)
        {
            playerCurrentHealth = playerMaxHealth;
        }
    }

    public void SetMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int minHealth = 0;
    public int currentHealth;

    public bool isDead;

    public GameManager gameManager;
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void Damage() 
    { 
        currentHealth -= 10;     
    }

    private void Update()
    {
        if (currentHealth <= minHealth && !isDead)
        {
            isDead = true;
            gameManager.GameOver();
            Debug.Log("Death");
        }
    }
}


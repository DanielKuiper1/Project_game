using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 50;
    public int minHealth = 0;
    public int currentHealth;
    private BulletDamage bulletDamage;
    public ExperienceDrop experienceDrop;
    public DestroyEnemy destroyEnemy;
    public PlayerHealth playerHealth;

    void Start()
    {
        currentHealth = maxHealth;
        FindPlayer();
    }
    public void SetBulletDamage(BulletDamage newBulletDamage)
    {
        bulletDamage = newBulletDamage;
    }
    void FindPlayer()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            playerHealth = player.GetComponent<PlayerHealth>();
        }
        else
        {
            Debug.LogError("Player GameObject not found. Ensure the player GameObject is tagged 'Player'.");
        }
    }
    public void Damage()
    {
        currentHealth -= bulletDamage.baseDamage;
    }

    private void Update()
    {
        if (currentHealth <= minHealth)
        {
            experienceDrop.SpawnExp();
            destroyEnemy.EnemyDestroy();
        }
        else if (playerHealth.isDead)
        {
            destroyEnemy.EnemyDestroy();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public bool isDamaging = false;
    public int baseDamage = 10;
    private EnemyHealth enemyHealth;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && !isDamaging)
        {
            enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
            isDamaging = true;
            enemyHealth.SetBulletDamage(this);
            InvokeRepeating("ApplyDamage", 0f, 1f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && isDamaging)
        {
            isDamaging = false;
            CancelInvoke("ApplyDamage");
        }
    }

    void ApplyDamage()
    {
        if (enemyHealth.currentHealth > enemyHealth.minHealth)
        {
            enemyHealth.Damage();
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        float distanceFromPlayer = Vector2.Distance(this.transform.position, player.transform.position);

        if (distanceFromPlayer > 50f)
        {
            Destroy(gameObject);
        }
    }
}

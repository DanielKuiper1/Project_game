using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTrigger : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public bool isDamaging = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !isDamaging)
        {
            playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            isDamaging = true;
            InvokeRepeating("ApplyDamage", 0f, 1f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && isDamaging)
        {
            isDamaging = false;
            CancelInvoke("ApplyDamage");
        }
    }

    void ApplyDamage()
    {
        if (playerHealth.currentHealth > playerHealth.minHealth)
        {
            playerHealth.Damage();
        }
    }
}

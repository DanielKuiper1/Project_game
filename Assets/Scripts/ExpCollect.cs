using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpCollect : MonoBehaviour
{
    public PlayerLevel playerLevel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerLevel = collision.gameObject.GetComponent<PlayerLevel>();
            playerLevel.ExpAdd();
            Destroy(gameObject);
        }
    }
}

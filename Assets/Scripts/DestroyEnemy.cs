using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public void EnemyDestroy()
    {
        Destroy(gameObject);
    }
}

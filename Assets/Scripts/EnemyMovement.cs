using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float pushSpeed = -1.5f;
    [SerializeField] float speed = 5.0f;
    [SerializeField] float stopDistance = 1.2f;
    [SerializeField] float pushDistance = 1.0f;
    private Transform player;



    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void FixedUpdate()
    {
        float distanceFromPlayer = Vector2.Distance(this.transform.position, player.transform.position);

        if (distanceFromPlayer > stopDistance)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }
        else if (distanceFromPlayer < pushDistance)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, pushSpeed * Time.deltaTime);
        }
    }
}

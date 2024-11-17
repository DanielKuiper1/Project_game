using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpPull : MonoBehaviour
{
    [SerializeField] float speed = 20.0f;
    [SerializeField] float pullDistance = 10.0f;
    private Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(this.transform.position, player.transform.position);

        if (distanceFromPlayer < pullDistance)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }
    }
}

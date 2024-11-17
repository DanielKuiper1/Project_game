using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] float followSpeed = 1f;
    [SerializeField] float followSpeedStationairy = 5f;
    [SerializeField] float holdSpeedDiagornal = 7f;
    [SerializeField] float holdSpeed = 10f;
    private Transform player;
    public PlayerMovement playerMovement;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        float distanceFromPlayer = Vector2.Distance(this.transform.position, player.transform.position);

        if (!playerMovement.isMoving)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, followSpeedStationairy * Time.deltaTime);
        }
        else if (playerMovement.isDiagonalMoving && distanceFromPlayer > 1f)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, holdSpeedDiagornal * Time.deltaTime);
        }
        else if (distanceFromPlayer < 1f)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, followSpeed * Time.deltaTime);
        }
        else if (distanceFromPlayer > 1f)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, holdSpeed * Time.deltaTime);
        }
    }
}

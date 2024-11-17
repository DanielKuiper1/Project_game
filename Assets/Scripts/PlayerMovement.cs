using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class PlayerMovement : MonoBehaviour
    {
        Rigidbody2D body;

        float horizontal;
        float vertical;
        float moveDiagonal = 0.7f;
    public bool isMoving;
    public bool isDiagonalMoving;
    public float speed = 20.0f;

        void Start()
        {
            body = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");
        }

        private void FixedUpdate()
        {
            if (horizontal != 0 || vertical != 0)
            {
                isMoving = true;
            }
            else
            {   
                isMoving = false;
            }

            if (horizontal != 0 && vertical != 0)
            {
                isDiagonalMoving = true;
                horizontal *= moveDiagonal;
                vertical *= moveDiagonal;
            }
            else
            {
                isDiagonalMoving = false;
            }

        body.velocity = new Vector2(horizontal * speed, vertical * speed);
        }
    }


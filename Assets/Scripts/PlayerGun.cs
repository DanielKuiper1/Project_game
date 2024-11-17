using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public GameObject projectilePrefab; // Reference to the projectile prefab
    public Transform shootPoint;        // Reference to the point from where the projectile will be instantiated
    public float projectileSpeed = 10f; // Speed of the projectile
    public float shootCooldown = 0.1f;  // Time between shots

    private float timeSinceLastShot;

    void Update()
    {
        timeSinceLastShot += Time.deltaTime;

        // Check for input (e.g., pressing the left mouse button)
        if (Input.GetButtonDown("Fire1") && timeSinceLastShot >= shootCooldown)
        {
            InvokeRepeating("Shoot", 0f, shootCooldown);
            timeSinceLastShot = 0f;
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            CancelInvoke("Shoot");
        }
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);

        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 shootDirection = (mousePosition - (Vector2)shootPoint.position).normalized;

        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.velocity = shootDirection * projectileSpeed;
    }
}

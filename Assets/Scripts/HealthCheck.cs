using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthCheck : MonoBehaviour
{
    public PlayerHealth playerHealth;
    private TextMeshProUGUI textMeshPro;

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        textMeshPro.text = $"{playerHealth.currentHealth}";
    }
}

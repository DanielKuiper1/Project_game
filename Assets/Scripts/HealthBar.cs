using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public int barX = 0;
    public float barWidth = 1.0f;
    public PlayerHealth playerHealth;
    public RectTransform healthBarRectTransform;

    void Update()
    {
        barWidth = 100f / playerHealth.maxHealth * playerHealth.currentHealth / 100f * 380f;

        healthBarRectTransform.anchoredPosition = new Vector2(barX, 0);
        healthBarRectTransform.sizeDelta = new Vector2(barWidth, 35);
    }
}

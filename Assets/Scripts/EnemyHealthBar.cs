using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    public int barX = 0;
    public float barWidth = 1.0f;
    public EnemyHealth enemyHealth;
    public RectTransform healthBarRectTransform;

    void Update()
    {
        barWidth = 100f / enemyHealth.maxHealth * enemyHealth.currentHealth / 100f * 0.95f;

        healthBarRectTransform.sizeDelta = new Vector2(barWidth, 0.5f);
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ExpBar : MonoBehaviour
{
    public int barX = 0;
    public float barWidth = 1.0f;
    public PlayerLevel playerLevel;
    public RectTransform expBarRectTransform;

    void Update()
    {
        barWidth = 100f / playerLevel.capExp * playerLevel.currentExp / 100f * 580f;

        expBarRectTransform.anchoredPosition = new Vector2(barX, 0);
        expBarRectTransform.sizeDelta = new Vector2(barWidth, 15);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelCheck : MonoBehaviour
{
    public PlayerLevel playerLevel;
    private TextMeshProUGUI textMeshPro;

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        textMeshPro.text = $"Level {playerLevel.currentLevel}";
    }
}

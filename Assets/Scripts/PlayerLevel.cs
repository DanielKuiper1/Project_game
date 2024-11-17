using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    public float currentExp;
    public float capExp;
    public int currentLevel;
    public ExpCollect expCollect;

    void Start()
    {
        capExp = 100f;
        currentExp = 0;
        currentLevel = 1;
    }

    public void ExpAdd()
    {
        currentExp += 10;
    }
    void Update()
    {
        if (currentExp >= capExp)
        {
            currentExp = 0;
            capExp *= 1.1f;
            currentLevel++;
        }
    }
}

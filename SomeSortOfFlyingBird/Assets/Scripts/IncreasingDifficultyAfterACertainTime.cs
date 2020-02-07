using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IncreasingDifficultyAfterACertainTime : MonoBehaviour
{
    public int difficultyLevel = 0;
    private int secondsPassed = 0;


    // Update is called once per frame
    void Update()
    {
        int secondsPassed = (int) Time.time;
        if(secondsPassed >= 30 && secondsPassed < 60)
        {
            difficultyLevel = 1;
        }else if(secondsPassed >= 60 && secondsPassed < 120)
        {
            difficultyLevel = 2;
        }
        else if(secondsPassed >= 120)
        {
            difficultyLevel = 3;
        }
        
    }
}

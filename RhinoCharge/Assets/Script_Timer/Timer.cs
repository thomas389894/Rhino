using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    float seconds = 10;
    float miliseconds = 0;

    string currentlevel = "Level_1"; 

    [SerializeField] Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = seconds + miliseconds;
    }

    // Update is called once per frame
    void Update()
    {
        if (miliseconds <= 0)
        {
            if (seconds <= 0)
            {
                seconds = 0;
                miliseconds = 0;
            }
            else if (seconds > 0)
            {
                seconds--;
                miliseconds = 100;
            }
        }

        miliseconds -= Time.deltaTime * 100;

        //Debug.Log(string.Format("{0}:{1}:{2}", minutes, seconds, (int)miliseconds));
        countdownText.text = string.Format("{0}:{1}", seconds, (int)miliseconds);

        if (Input.GetKeyDown(KeyCode.I))
        {
            currentlevel = "Level_2";
            AddTimerLevel();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            currentlevel = "Level_3";
            AddTimerLevel();
        }
    }
    public void AddTimerLevel()
    {
        if (currentlevel == "Level_2")
        {
            seconds += 10;
        }
        if (currentlevel == "Level_3")
        {
            seconds += 5;
        }
        else
        {
            seconds += 3;
        }
    }
}

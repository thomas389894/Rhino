using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    float seconds = 10;
    float miliseconds = 0;

    [SerializeField] public Scene currentscene;
    [SerializeField] public string difficulty = "Normal";
    public string Levelname;
    [SerializeField] Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = seconds + miliseconds;
        Levelname = currentscene.name;
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
            //currentscene == ;
            AddTimerLevel();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            //currentscene = ref Object.Equals;
            AddTimerLevel();
        }
    }
    public void AddTimerLevel()
    {
        if (Levelname == "Level_1")
        {
            if (difficulty == "Facile")
            {
                seconds += 12;
            }
            if (difficulty == "Normal")
            {
                seconds += 10;
            }
            if (difficulty == "Difficile")
            {
                seconds += 5;
            }
        }
        
        if (Levelname == "Level_2")
        {
            seconds += 5;
        }
        else
        {
            seconds += 3;
        }
    }
    public void BonusTime()
    {
        
    }
}

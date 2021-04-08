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
    float AddTime;

    
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

        if (Input.GetKeyDown(KeyCode.I)/* if niveau fini alors ajouter du temps au compteur*/)
        {
            AddTimerLevel();
            if (currentTime <=2)
            {
                difficulty = "Facile";
            }
            if (currentTime <= 5)
            {
                difficulty = "Normal";
            }
            if (currentTime > 6)
            {
                difficulty = "Difficile";
            }
        }
        
    }
    public void AddTimerLevel()
    {
        if (Levelname == "Level_1")
        {
            if (difficulty == "Facile")
            {
                AddTime = 5;
                currentTime += AddTime;
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

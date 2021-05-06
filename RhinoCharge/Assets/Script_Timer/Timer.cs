using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    /* var theGameObject : GameObject = GameObject.Find(targetObject);
        var theComponent : TargetScript = theGameObject.GetComponent(TargetScript );
         var theVarThatIsAnInt : int = theComponent.theVariableOnTargetScriptThatIsAnInt;*/

    float currentTime = 0f;
    float startingTime = 10f;

    float seconds = 10;
    float miliseconds = 0;
    float AddTime;
    int levelEasy;


    [SerializeField] public Scene currentscene;
    [SerializeField] public string difficulty = "Normal";
    public string Levelname;
    [SerializeField] Text countdownText;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = seconds + miliseconds;
        Levelname = currentscene.name;
        //levelEasy = GameObject.FindGameObject<Map_Manager>();
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
        OverTime();
    }
    public void AddTimerLevel()
    {
        if (difficulty == "Facile")
        {
            AddTime = 6;
            currentTime += AddTime;
        }
        if (difficulty == "Normal")
        {
            AddTime = 3;
            currentTime += AddTime;
        }
        if (difficulty == "Difficile")
        {
            AddTime = 2;
            currentTime += AddTime;
        }
    }
    public void BonusTime()
    {
        
    }
    public void OverTime()
    {
        if (seconds <= 0 && miliseconds <= 0)
        {
            countdownText.text = string.Format("Game Over !");
            Debug.Log("Game Over !");
        }
        else
        {
            Debug.Log("Play");
        }
    }
    public void Levelcomplit()
    {
        
    }
}

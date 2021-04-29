using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ennemy_Manager : MonoBehaviour
{
    int ennemyCount = 0;
    public int ennemy = 0;

    GameObject[] doors;
    

    // Start is called before the first frame update
    void Start()
    {

        doors = GameObject.FindGameObjectsWithTag("Door");
        

        CheckCurrentLevel();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            CheckCurrentLevel();
        }
    }

    public void CheckCurrentLevel()
    {
        //Easy
        if (SceneManager.GetActiveScene().name == "Lvl_01")
        {          
            ennemyCount = 3;

            if(ennemy == ennemyCount)
            {
                foreach (GameObject d in doors)
                {
                    Debug.Log(d);
                    d.GetComponent<BoxCollider2D>().enabled = true;
                }
                //DoorsOpen;
            }
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_02")
        {
            ennemyCount = 3;

            if (ennemy == ennemyCount)
            {
                //DoorsOpen;
            }
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_03")
        {
            ennemyCount = 1;

            if (ennemy == ennemyCount)
            {
                //DoorsOpen;
            }
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_04")
        {
            ennemyCount = 3;

            if (ennemy == ennemyCount)
            {
                //DoorsOpen;
            }
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_05")
        {
            ennemyCount = 3;

            if (ennemy == ennemyCount)
            {
                //DoorsOpen;
            }
        }
        else if (SceneManager.GetActiveScene().name == "Lvl_06")
        {
            ennemyCount = 1;

            if (ennemy == ennemyCount)
            {
                //DoorsOpen;
            }
        }

        //Medium
        else if (SceneManager.GetActiveScene().name == "Lvl_07")
        {

        }
        else if (SceneManager.GetActiveScene().name == "Lvl_08")
        {

        }
        else if (SceneManager.GetActiveScene().name == "Lvl_09")
        {

        }
        else if (SceneManager.GetActiveScene().name == "Lvl_10")
        {

        }
        else if (SceneManager.GetActiveScene().name == "Lvl_11")
        {

        }
        else if (SceneManager.GetActiveScene().name == "Lvl_12")
        {

        }

        //Hard
        else if (SceneManager.GetActiveScene().name == "Lvl_13")
        {

        }
        else if (SceneManager.GetActiveScene().name == "Lvl_14")
        {

        }
        else if (SceneManager.GetActiveScene().name == "Lvl_15")
        {

        }
        else if (SceneManager.GetActiveScene().name == "Lvl_16")
        {

        }
        else if (SceneManager.GetActiveScene().name == "Lvl_17")
        {

        }
        else if (SceneManager.GetActiveScene().name == "Lvl_18")
        {

        }



    } 
}

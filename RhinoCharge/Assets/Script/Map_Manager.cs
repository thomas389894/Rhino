using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Map_Manager : MonoBehaviour
{
    public List<int> easyLevel = new List<int>();
    public List<int> mediumLevel = new List<int>();
    public List<int> hardLevel = new List<int>();

    bool easy = true;
    bool medium = false;
    bool hard = false;

    int e;
    int m;
    int h; 
    int countLevels;

    // Start is called before the first frame update
    void Start()
    {
        e = PlayerPrefs.GetInt("saveNewSizeEasyLvl");
        m = PlayerPrefs.GetInt("saveNewSizeMediumLvl");
        h = PlayerPrefs.GetInt("saveNewSizeHardLvl");

        medium = (PlayerPrefs.GetInt("medium") != 0);
        hard = (PlayerPrefs.GetInt("hard") != 0);

        countLevels = PlayerPrefs.GetInt("countLvl");

        Debug.Log(easy);
        Debug.Log(medium);
        Debug.Log(hard);
        Debug.Log(countLevels);

        easyLevel.RemoveAt(e);
        mediumLevel.RemoveAt(m);
        hardLevel.RemoveAt(h);

        CheckVariables();


    }

    // Update is called once per frame
    void Update()
    {
        CleanSave();
    }
    //Level boss en attente d'implementation ! 

    public void RandomMap()
    {
        if (easy == true && medium == false && hard == false)
        {
            Debug.Log("Welcome in easyland");

            e = Random.Range(0, easyLevel.Count);
            countLevels += 1;

            if (countLevels < 4)
            {
                if (e == 0)
                {
                    SceneManager.LoadScene("Lvl_01");
                    Debug.Log("Level 01");
                }
                else if (e == 1)
                {
                    SceneManager.LoadScene("Lvl_02");
                    Debug.Log("Level 02");
                }
                else if (e == 2)
                {
                    SceneManager.LoadScene("Lvl_03");
                    Debug.Log("Level 03");
                }
                else if (e == 3)
                {
                    SceneManager.LoadScene("Lvl_04");
                    Debug.Log("Level 04");
                }
                else if (e == 4)
                {
                    SceneManager.LoadScene("Lvl_05");
                    Debug.Log("Level 05");
                }
                else if (e == 5)
                {
                    SceneManager.LoadScene("Lvl_06");
                    Debug.Log("Level 06");
                }
            }
            else
            {
                CheckVariables();
            }

            PlayerPrefs.SetInt("saveNewSizeEasyLvl", e);
            PlayerPrefs.SetInt("countLvl", countLevels);

            easyLevel.RemoveAt(e);


        }
        else if (easy == true && medium == true && hard == false)
        {
            Debug.Log("Welcome in mediumland");

            m = Random.Range(0, mediumLevel.Count);
            countLevels += 1;

            if (countLevels < 4)
            {
                if (m == 0)
                {
                    SceneManager.LoadScene("Lvl_07");
                    Debug.Log("Level 07");
                }
                else if (m == 1)
                {
                    SceneManager.LoadScene("Lvl_08");
                    Debug.Log("Level 08");
                }
                else if (m == 2)
                {
                    SceneManager.LoadScene("Lvl_09");
                    Debug.Log("Level 09");
                }
                else if (m == 3)
                {
                    SceneManager.LoadScene("Lvl_10");
                    Debug.Log("Level 10");
                }
                else if (m == 4)
                {
                    SceneManager.LoadScene("Lvl_11");
                    Debug.Log("Level 11");
                }
                else if (m == 5)
                {
                    SceneManager.LoadScene("Lvl_12");
                    Debug.Log("Level 12");
                }
            }
            else
            {
                CheckVariables();
            }

            PlayerPrefs.SetInt("saveNewSizeMediumLvl", m);
            PlayerPrefs.SetInt("countLvl", countLevels);

            mediumLevel.RemoveAt(m);
        }
        else if (easy == true && medium == true && hard == true)
        {
            Debug.Log("Welcome in hardland");

            h = Random.Range(0, hardLevel.Count);
            countLevels += 1;

            if (countLevels < 4)
            {
                if (h == 0)
                {
                    SceneManager.LoadScene("Lvl_13");
                    Debug.Log("Level 13");
                }
                else if (h == 1)
                {
                    SceneManager.LoadScene("Lvl_14");
                    Debug.Log("Level 14");
                }
                else if (h == 2)
                {
                    SceneManager.LoadScene("Lvl_15");
                    Debug.Log("Level 15");
                }
                else if (h == 3)
                {
                    SceneManager.LoadScene("Lvl_16");
                    Debug.Log("Level 16");
                }
                else if (h == 4)
                {
                    SceneManager.LoadScene("Lvl_17");
                    Debug.Log("Level 17");
                }
                else if (h == 5)
                {
                    SceneManager.LoadScene("Lvl_18");
                    Debug.Log("Level 18");
                }
            }
            else
            {
                CheckVariables();
            }

            PlayerPrefs.SetInt("saveNewSizeHardLvl", h);
            PlayerPrefs.SetInt("countLvl", countLevels);

            hardLevel.RemoveAt(h);
        }

    }

    public void CheckVariables()
    {
        if (countLevels >= 3)
        {
            if (easy == true && medium == false && hard == false)
            {
                medium = true;
                countLevels = 0;
                Debug.Log("EasyFinish");
                PlayerPrefs.SetInt("medium", medium ? 1 : 0);
            }
            else if (easy == true && medium == true && hard == false)
            {
                hard = true;
                countLevels = 0;
                Debug.Log("MediumFinish");
                PlayerPrefs.SetInt("hard", hard ? 1 : 0);
            }
            else if (easy == true && medium == true && hard == true)
            {
                countLevels = 0;
                Debug.Log("HardFinish");
            }

        }
    }

    public void CleanSave()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
            SceneManager.LoadScene("Main");
            Debug.Log("Clean");
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            RandomMap();

        }
    }
}

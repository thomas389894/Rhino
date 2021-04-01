using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Manager : MonoBehaviour
{

    int[] easyLevels = new int[6];
    int[] mediumLevels = new int[6];
    int[] hardLevels = new int[6];

    bool easy = true;
    bool medium = false;
    bool hard = false;

    int e;
    int m;
    int h;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RandomMap()
    {
        if(easy == true && medium == false && hard == false)
        {
            e = Random.Range(0, easyLevels.Length);

           // easyLevels = easy.Levels.Where((source, index) => )

        }
        else if(easy == true && medium == true && hard == false)
        {
            m = Random.Range(0, mediumLevels.Length);
        }
        else if (easy == true && medium == true && hard == true)
        {
            h = Random.Range(0, hardLevels.Length);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticEnnemy_2Hit : MonoBehaviour
{
    //public text =  "Ennemy1Hit";
    int vieEnnemy = 2;

    public Ennemy_Manager scriptEnnemy;

    // Start is called before the first frame update
    void Start()
    {
        scriptEnnemy = FindObjectOfType<Ennemy_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            vieEnnemy -= 1;

            if(vieEnnemy <= 0)
            {
                scriptEnnemy.ennemy += 1;
                scriptEnnemy.CheckCurrentLevel();
                Destroy(this);
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticEnnemy : MonoBehaviour
{
    //public text =  "Ennemy1Hit";

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
        if(col.gameObject.name == "Player")
        {
            scriptEnnemy.ennemy += 1;
            scriptEnnemy.CheckCurrentLevel();
            Destroy(this);
        }
    }

}

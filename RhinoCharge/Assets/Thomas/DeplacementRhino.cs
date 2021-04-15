using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementRhino : MonoBehaviour
{

    private Rigidbody2D player;
    public float speed = 6.0f;
    public float Ypos = 1;
    public float Xpos= 1;
    public float Yneg = -1;
    public float Xneg = -1;
    public float DirX;
    public float DirY;
    public bool canMove = true;
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Z) && canMove == true)
        {
            DirY = Ypos;
            DirX = 0;
            canMove = false;
        }

        if (Input.GetKeyDown(KeyCode.S) && canMove == true)
        {
            DirY = Yneg;
            DirX = 0;
            canMove = false;
        }

        if (Input.GetKeyDown(KeyCode.Q) && canMove == true)
        {
            DirX = Xneg;
            DirY = 0;
            canMove = false;
        }

        if (Input.GetKeyDown(KeyCode.D) && canMove == true)
        {
            DirX = Xpos;
            DirY = 0;
            canMove = false;
        }

        if (Input.GetKeyDown(KeyCode.D) && (Input.GetKeyDown(KeyCode.Z)) && canMove == true)
        {
            DirX = Xpos;
            DirY = Ypos;
            canMove = false;
        }

        if (Input.GetKeyDown(KeyCode.Q) && (Input.GetKeyDown(KeyCode.Z)) && canMove == true)
        {
            DirX = Xneg;
            DirY = Ypos;
            canMove = false;
        }

        if (Input.GetKeyDown(KeyCode.D) && (Input.GetKeyDown(KeyCode.S)) && canMove == true)
        {
            DirX = Xpos;
            DirY = Yneg;
            canMove = false;
        }

        if (Input.GetKeyUp(KeyCode.Q) && (Input.GetKeyUp(KeyCode.S)) && canMove == true)
        {
            DirX = Xneg;
            DirY = Yneg;
            canMove = false;
        }







        Vector2 direction = new Vector2(DirX, DirY) * speed;
        player.AddForce(direction, ForceMode2D.Force);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            player.velocity = Vector2.zero;
            canMove = true;
        }
    }

}

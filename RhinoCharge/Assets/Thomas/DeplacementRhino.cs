using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementRhino : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed = 2f;
    public Vector2 movement;
    public bool push;
    public float speedMax = 15;
    public float speedMin = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");

       if (movement.x != 0 || movement.y != 0)
        {
            push = true;
        }
       else
        {
            push = false;
        }

       if (push == true)
        {
            speed++;
        }
       else
        {
            speed--;
        }

       if (push == false && speed <= speedMin)
        {
            speed = speedMin;
        }

       if (push == true && speed >= speedMax)
        {
            speed = speedMax;
            Debug.Log("TooFast");
        }
        
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
       // rb.velocity(movement.x,movement.y);
    }
}

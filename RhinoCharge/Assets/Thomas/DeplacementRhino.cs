using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementRhino : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 10f;
    public Vector3 movement;
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
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //Apply the movement vector to the current position, which is
        //multiplied by deltaTime and speed for a smooth MovePosition
        rb.AddForce(m_Input  * speed * Time.deltaTime);
    }
}

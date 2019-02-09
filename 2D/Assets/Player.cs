using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public PlayerMvmnt controller;
    public Rigidbody2D rb;
  
    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool isGoingRight = false;
    bool isGoingLeft = false;
    bool isGoingUp = false;
    bool isGoingDown = false;
    // bool crouch = false;

    // Update is called once per frame
    void Update()
    {
        
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
    
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        

        /* if (Input.GetButtonDown("Crouch"))
         {
             crouch = true;
         }
         else if (Input.GetButtonUp("Crouch"))
         {
             crouch = false;
         }*/
         
    }

    void FixedUpdate()
    {
        // Move our character
        if (Input.GetKey("t"))
        {
            isGoingRight = true;
        }
        //while (isGoingRight)
        //{
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
            if (Input.GetKey("a"))
            {
                isGoingRight = false;
                isGoingLeft = true;
            }
        //}
        //while (isGoingLeft)
        //{
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, true);
            if (Input.GetKey("d"))
            {
                isGoingLeft = false;
                isGoingRight = true;
            }
        //}
       /* {
            
        }
        if (Input.GetKey("d"))
        {
            controller.Move(-100f * Time.fixedDeltaTime, false, true);
        }

        jump = false;*/
    }
}
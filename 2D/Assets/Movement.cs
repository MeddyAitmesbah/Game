using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public PlayerMvmnt controller;
    public Rigidbody2D rb;
    public Vector2 V;
    bool moveDown = false;
    bool moveUp = false;
    bool moveleft = false;
    bool moveright = false;
    bool goingright = false;
    bool goingleft = false;
    bool goingDown = false;
    bool goingUp = false;
    bool RightSide = false;
    bool LeftSide = false;
    bool Facing_Right = true;
    // Use this for initialization
    void Start()
    {
        goingright = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "RightPlateforme" || collision.collider.tag == "MiddlePlateforme")
        {
            rb.AddForce(V, 0);
            RightSide = true;
            LeftSide = false;
        }
        if (collision.collider.tag == "LeftPlateforme")
        {
            rb.AddForce(V, 0);
            LeftSide = true;
            RightSide = false;
        }
        if (collision.collider.tag == "TopPlateforme")
        {
            V.y = 500f;
            rb.AddForce(V, 0);
        }


    }
    /*
    public Vector2 aPosition1 = new Vector2(-0.05f, 8f);*/

    void Update()
    {

            if (Input.GetKeyDown("d"))
            {
                moveright = true;
                if (!Facing_Right)
                {
                    Flip();
                }
            }

            if (Input.GetKeyDown("q"))
            {
                moveleft = true;
                if (Facing_Right)
                { 
                    Flip();
                }
            }

            if (Input.GetKeyDown("s"))
            {
                moveDown = true;
                if (Facing_Right)
                {
                    Flip();
                }
            }
            if (Input.GetKeyDown("z"))
            {
            moveUp = true;
                 if (!Facing_Right)
                 {
                    Flip();
                 }       
            }
        if (moveright && RightSide)
        {
            V.x = 175f;
            V.y = 500f;
            moveright = false; 
        }
        if(moveright && LeftSide)
        {
            V.x = 175f;
            V.y = 850f;
            
            moveright = false;
        }

        if (moveleft && LeftSide)
        {
            V.x = -175f;
            V.y = 500f;
            moveleft = false;
        }
        if (moveleft && RightSide)
        {
            V.x = -175f;
            V.y = 850f;
            moveleft = false;
        }
        if (moveDown && RightSide)
        {
            V.x = -175f;
            V.y = 500f;
            moveDown = false;
        }
        if (moveDown && LeftSide)
        {
            V.x = 175f;
            V.y = 500f;
            moveDown = false;
        }
        if (moveUp && LeftSide)
        {
            V.x = -175f;
            V.y = 850f;
            moveUp = false;
        }
        if (moveUp && RightSide)
        {
            V.x = 175f;
            V.y = 850f;
            moveUp = false;
        }

    }
    private void Flip()
    {

        Facing_Right = !Facing_Right;
        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}


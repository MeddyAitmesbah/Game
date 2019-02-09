using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour
{

    Color m_NewColor;
    SpriteRenderer m_rend;

    float m_Red;

    void Start()
    {
       
        //Get the renderer of the object so we can access the color
        m_rend = GetComponent<SpriteRenderer>();
        //Set the initial color (0f,0f,0f,0f)
        m_rend.color = Color.white;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            m_rend.color = Color.red;
        }
    }
}
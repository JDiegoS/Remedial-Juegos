using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBG : MonoBehaviour
{
    public BoxCollider2D bg;
    public Rigidbody2D rb;
    public GameObject pl;
    private float length;
    private bool defeat = false;
    // Start is called before the first frame update
    void Start()
    {
        length = bg.size.x;
        rb.velocity = new Vector2(-1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (pl == null)
        {
            rb.velocity = Vector2.zero;
        }
        if(transform.position.x <= -9.24 && defeat == false)
        {
            Debug.Log(rb.transform.position.x);
            Repeat();
        }
    }
    void Repeat()
    {
        transform.Translate(Vector2.right*18.5f);
    }
    void Defeat()
    {
        defeat = true;
        rb.velocity = Vector2.zero;
    }

}

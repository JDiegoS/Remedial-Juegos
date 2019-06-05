using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D bird;
    public GameObject canvas;
    public AudioClip poin;
    public AudioClip death;
    public AudioClip flap;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioSource sound = GetComponent<AudioSource>();
            sound.PlayOneShot(flap);
            bird.AddForce(new Vector2(0, 400f));
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            AudioSource sound = GetComponent<AudioSource>();
            sound.PlayOneShot(death);
            canvas.SendMessage("Hit");
            canvas.SendMessage("Defeat");
            Time.timeScale = 0.0f;
        }
        if (collision.gameObject.tag == "Point")
        {
            AudioSource sound = GetComponent<AudioSource>();
            sound.PlayOneShot(poin);
            canvas.SendMessage("Punto");
        }
    }

}

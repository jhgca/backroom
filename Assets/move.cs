using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public AudioSource sound;
    public bool ismoving;
    public float moveSpeed = 5f; // Adjust this to control the movement speed.
    bool canmove = true;
    private Rigidbody2D rb;
    private Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sound = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (!canmove)
            return;
        // Get input from the arrow keys or WASD keys.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction.
        Vector2 movement = new Vector2(horizontalInput, verticalInput);

        // Apply the movement to the Rigidbody2D.
        rb.velocity = movement * moveSpeed;
        if (movement != Vector2.zero)
        {
            if (ismoving == false)
            {
                ismoving = true;
                sound.Play();
            }
        }
        else
        {
            if (ismoving == true)
            {
                ismoving = false;
                sound.Stop();
            }
        }
        anim.SetBool("iswalking" , ismoving);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            joever.main.activeJoever();
            canmove = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private float movement = 0f;
    public float jumpHeight = 0;
    public float canJump = 0f;
    public bool isJumping = false;
    public Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

    }
    
    void Update()
    {
        //Player movement along x-axis
        movement = Input.GetAxis("Horizontal");
        Vector2 position = transform.position;

        if ((movement > 0f) || (Input.GetKeyDown(KeyCode.A)))
        {
            rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);
        }
        else if ((movement < 0f) || (Input.GetKeyDown(KeyCode.D)))
        {
            rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);
        }
        else
        {
            rigidBody.velocity = new Vector2(0, rigidBody.velocity.y);
        }

        //Player model flips as A or D is pushed
        Vector2 charecterScale = transform.localScale;
        //Bug: Save y position "better" so not visible when flipping
        if (isJumping == false)
        {
            if (movement < 0)
            {
                charecterScale.x = (float)-1;
                transform.position = new Vector2(transform.position.x, -2.775242f);
            }
            if (movement > 0)
            {
                charecterScale.x = (float)1;
                transform.position = new Vector2(transform.position.x, -2.775242f);
            }
            transform.localScale = charecterScale;
        }


        //Player jump
        //Bug: fix y position save conflicting with jump.
        //Bug: jumping messes with physics - fix
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > canJump)
        {
            isJumping = true;
            rigidBody.AddForce((Vector2.up * jumpHeight), ForceMode2D.Impulse);
            canJump = Time.time + .7f;
            
        }
        isJumping = false;


    }

}




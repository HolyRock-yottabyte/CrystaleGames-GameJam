using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Vector3 moveInput;

    public bool canMove, isGrounded;
    public float speed, jumpForce;

    public int maxJumps, currentJumps;

    public Rigidbody2D rb2D;
    
    void Start()
    {
        canMove = true;

        rb2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        //get input and move by it
        moveInput = new Vector3(Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed, 0, 0);


        //jump

        if(Input.GetKeyDown(KeyCode.UpArrow) && currentJumps > 0)
        {
            jump();
        }
    }

    public void jump()
    {
        rb2D.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        currentJumps --;
    }

    public void die()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    void FixedUpdate()
    {
        if(canMove)
        {
            transform.position += moveInput;
        }
    }
}

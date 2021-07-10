using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Vector3 moveInput;

    public bool canMove, isGrounded;
    public float speed, jumpForce;

    public Rigidbody2D rb2D;
    
    void Start()
    {
        canMove = true;

        rb2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        //get input and move by it
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed, 0, 0);
        if(canMove)
        {
            transform.position += moveInput;
        }

        //jump
        if(Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            jump();
        }
    }

    public void jump()
    {
        rb2D.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }
}

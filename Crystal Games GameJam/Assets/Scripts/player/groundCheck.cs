using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{
    public playerController pc;
    public bool grounded;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        pc.isGrounded = grounded;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.layer == 7)
        {
            grounded = true;
            pc.currentJumps = pc.maxJumps;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.layer == 7)
        {
            grounded = false;
        }
    }
}

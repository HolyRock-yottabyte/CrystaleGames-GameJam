using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapped_01 : MonoBehaviour
{
    Vector3 moveInput;
    void Update()
    {
        moveInput = new Vector3(Input.GetAxis("Horizontal") * Time.fixedDeltaTime * 2, 0, 0);
    }

    void FixedUpdate()
    {
        if(true)
        {
            transform.position += moveInput;
        }
    }
}

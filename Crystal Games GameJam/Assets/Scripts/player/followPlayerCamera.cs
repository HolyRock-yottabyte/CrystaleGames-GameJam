using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayerCamera : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void LateUpdate()
    {
        if(GameObject.Find("player") !=null)
        {
            Vector3 toGo = GameObject.Find("player").transform.position;
            toGo.z = -10;
            toGo.y += 0.6f;

            transform.position = toGo;
        }


        
    }
}

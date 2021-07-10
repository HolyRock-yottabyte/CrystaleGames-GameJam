using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayerCamera : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 toGo = Vector3.Lerp(transform.position, GameObject.Find("player").transform.position, 0.1f);
        toGo.z = -10;

        transform.position = toGo;
    }
}

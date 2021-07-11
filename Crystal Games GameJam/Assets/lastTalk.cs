using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastTalk : MonoBehaviour
{
    public GameObject canv;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canv.GetComponent<Animator>().SetTrigger("talk");
        collision.GetComponent<playerController>().canMove = false;
    }
}

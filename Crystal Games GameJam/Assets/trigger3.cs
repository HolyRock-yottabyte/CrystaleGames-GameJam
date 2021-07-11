using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trigger3 : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("player").GetComponent<Animator>().SetTrigger("tape");
        Invoke("load", 0.15f);
    }

    void load()
    {
        SceneManager.LoadScene("tape4");
    }
}

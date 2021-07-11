using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trapped_02 : MonoBehaviour
{
    public string sceneName;

    public GameObject him;

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "player")
        {
            SceneManager.LoadScene(sceneName);
            him.SetActive(true);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_1sceneLoader : MonoBehaviour
{
    public string sceneName;

    void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene(sceneName);
    }
}

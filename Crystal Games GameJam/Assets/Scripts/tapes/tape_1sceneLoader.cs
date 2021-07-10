using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tape_1sceneLoader : MonoBehaviour
{
    public string sceneN;

    void Start()
    {
        SceneManager.LoadScene(sceneN);
    }
}

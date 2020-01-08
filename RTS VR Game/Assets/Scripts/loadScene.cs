using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    public void LoadA(int sceneNum)
    {
        Debug.Log("sceneName to load: " + sceneNum);
        SceneManager.LoadScene(sceneNum);
    }
}

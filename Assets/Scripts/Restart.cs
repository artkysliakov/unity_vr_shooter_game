using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {

    //private int randome = Random.Range(1, 3);

    public void ReloadLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void LoadLevel_1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void LoadLevel_2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

    public void LoadRandomeLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Random.Range(1, 3));
    }
}

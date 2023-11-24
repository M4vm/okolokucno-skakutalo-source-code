using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    //public GameObject LoadingScreen;
    //public static bool loading = false;

    public void PlayGame()
    {
        //loading = true;
        //LoadingScreen.SetActive(loading);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

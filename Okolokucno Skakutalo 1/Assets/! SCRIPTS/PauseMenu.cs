using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject player;
    public GameObject audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }   else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        player.GetComponent<PlayerMovement>().enabled = true;
        pauseMenuUI.SetActive(false);

        AudioListener.volume = 1;
        AudioListener.pause = false;

        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        player.GetComponent<PlayerMovement>().enabled = false;
        pauseMenuUI.SetActive(true);

        AudioListener.volume = 0;
        AudioListener.pause = true;

        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

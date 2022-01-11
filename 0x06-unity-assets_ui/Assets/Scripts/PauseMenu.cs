using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PauseMenu : MonoBehaviour
{
    private bool gamePaused ;
    public Canvas PauseCanva;

    private void Start()
    {
        gamePaused = true;

        PauseCanva.enabled = false;
    }
    private void Update()
    {
        // Pause the game when the user press the Cancel button.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
    }
    /// <summary>
    /// Pause the game.
    /// </summary>
    public void Pause()
    {
        gamePaused = true;
        Time.timeScale = 0;
        PauseCanva.enabled = true;
    }
    /// <summary>
    /// Resume the game.
    /// </summary>
    public void Resume()
    {
        gamePaused = false;
        Time.timeScale = 1;
        PauseCanva.enabled = false;

    }
    /// <summary>
    /// Restart the game.
    /// </summary>
    public void Restart()
    {
        Scene currentLevel = SceneManager.GetActiveScene();
        Resume();
        SceneManager.LoadScene(currentLevel.buildIndex);
    }

    /// <summary>
    /// Load the main menu.
    /// </summary>
    public void MainMenu()
    {
        Resume();
        SceneManager.LoadScene(0);
    }
    /// <summary>
    /// Loads the options.
    /// </summary>
    public void Options()
    {
        Resume();
        SceneManager.LoadScene(4);
    }
}

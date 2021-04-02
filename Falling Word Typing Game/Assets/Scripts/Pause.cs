using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public Canvas pauseMenu;
    private bool isPaused;
    private void Awake()
    {
        pauseMenu.enabled = false;
        isPaused = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused == false)
            {
                pauseGame();
                isPaused = true;
            }
            else
            {
                unPauseGame();
                isPaused = false;
            }
        }
    }

    public void pauseGame()
    {
        pauseMenu.enabled = true;
        Cursor.visible = true;
        Time.timeScale = 0;
    }

    public void unPauseGame()
    {
        pauseMenu.enabled = false;
        Cursor.visible = false;
        Time.timeScale = 1;
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void backToStart()
    {
        SceneManager.LoadScene("Intro");
        Cursor.visible = true;
    }
}

using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{
    public InputField inputName;
    public Text scoreText;
    public Text nameText;
    public static string playerName;
    public static int score;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void Update()
    {
        scoreText.text = "Score: " + score;
    }

    public void setName()
    {
        playerName = inputName.text;
        Debug.Log(playerName);
    }

    public void resetScore()
    {
        score = 0;
        playerName = "default";
    }

    public void setScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void getName()
    {
        nameText.text = playerName;
    }
}


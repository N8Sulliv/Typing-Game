using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordDisplay : MonoBehaviour
{
    private WordManager manager;
    private WordSpawner spawner;
    private KeepData data;
    public Text text;

    public bool outOfBounds = false;

    public float fallspeed = 1f;

    public void setWord(string word)
    {
        text.text = word;
    }

    public void removeLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.cyan;
    }

    public void removeWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(0f, -fallspeed * Time.deltaTime, 0f);

        if (this.gameObject.transform.position.y <= -5)
        {
            outOfBounds = true;
        }

        if (this.gameObject.transform.position.y <= -6)
        {
            removeWord();
            SceneManager.LoadScene("End");
        }
    }
}


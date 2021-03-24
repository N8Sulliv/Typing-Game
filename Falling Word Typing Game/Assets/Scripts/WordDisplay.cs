using UnityEngine.UI;
using UnityEngine;

public class WordDisplay : MonoBehaviour
{
    public Text text;

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
    }
}


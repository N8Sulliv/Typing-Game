using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform canvas;
    public WordDisplay spawnWord()
    {
        float spawnX = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2((Screen.width + 2), 0)).x);

        Vector2 randomPosition = new Vector2(spawnX, 7f);

        GameObject wordobj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, canvas);
        WordDisplay wordDisplay = wordobj.GetComponent<WordDisplay>();


        return wordDisplay;
    }
}

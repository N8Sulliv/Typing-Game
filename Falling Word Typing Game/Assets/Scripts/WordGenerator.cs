using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordlist = { "berserk", "slim", "rod", "numberless", "hapless", "color", "arch", "playground", "waves", "smile", "stupid", "amusement", "contain", "elbow", "recondite", "teaching", "heat", "lively", "screw", "flap", "toys", "alluring", "cute", "spark", "shirt", "whirl", "fireman", "shrug", "mom", "kick", "purple", "trains", "magical", "repulsive", "travel", "drink", "sugar", "cellar", "clean", "aboriginal", "awesome", "questionable", "development", "jam", "territory", "adjoining", "fancy", "cool", "locket", "cry", };
    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordlist.Length);
        string randomWord = wordlist[randomIndex];

        return randomWord;
    }


}

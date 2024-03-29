﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    public List<Word> words;

    private bool hasActiveWord;
    private Word activeWord;

    public WordSpawner wordSpawner;


    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.spawnWord());

        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            KeepData.score += 10;
            
            if (activeWord.getNextLetter() == letter)
            {
                activeWord.TypeLetter();                
            }
        }
        else
        {
            foreach(Word word in words)
            {
                if (word.getNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
            KeepData.score += 100;
        }
    }
}

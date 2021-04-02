using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    public WordTimer timer;
    public Save createSave()
    {
        Save save = new Save();

        save.score = KeepData.score;
        save.wordDelay = timer.wordDelay;

        return save;
    }
}

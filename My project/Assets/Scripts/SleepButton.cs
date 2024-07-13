using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SleepButton : MonoBehaviour
{
    static int nextChapter;
    public void MoveChapter() {
        Birds.played = 0;
        LightMovement.played = 0;
        GameController.played = 0;
        Debug.Log("Зашёл");

        nextChapter = PlayerPrefs.GetInt("Chapter") +1;
        Debug.Log("Знач" + nextChapter);
        if (nextChapter < 8)
        {
            Debug.Log("Зашёл в цикл");
            SceneManager.LoadScene(nextChapter);
        }
    }

    // Start is called before the first frame update
    
}

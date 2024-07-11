using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public static int chek;
    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
        if (sceneID == 0)
        {
            chek = 1;
        }

    }
}

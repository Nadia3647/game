using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayBar : MonoBehaviour
{
    public static Image Bar;
    float value;
    float static updateValue;
    static int playVal;


    private void Start()
    {
        Bar = GetComponent<Image>();
        updateValue = PlayerPrefs.GetFloat("playBarBal");
        Bar.fillAmount = updateValue;
        if (LightMovement.chek == 1)
        {
            Play();
            GameController.chek = 0;
        }
    }

    public static void SetPlayBarValue(float value)
    {
        Bar.fillAmount = value;
    }
    public static float GetPlayBarValue()
    {
        return Bar.fillAmount;
    }
    public static void Play()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 3)
        {
            playVal = PlayerPrefs.GetInt("lightScore");
            Debug.Log("Play: " + playVal);
            updateValue = GetPlayBarValue() + 0.01f * playVal;
            PlayerPrefs.SetFloat("playBarBal", updateValue);
            SetPlayBarValue(updateValue);
        }

    }
}
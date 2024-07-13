using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayBar : MonoBehaviour
{
    public static Image Bar;
    float value;
    static float updateValue = 0.0f;
    static int playVal;


    private void Start()
    {
        Bar = GetComponent<Image>();
        updateValue = PlayerPrefs.GetFloat("playBarBal");
        Bar.fillAmount = updateValue;
        if (LightMovement.chek == 1)
        {
            Play();
            LightMovement.chek = 0;
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
        if (currentSceneIndex == 1)
        {
            playVal = PlayerPrefs.GetInt("lightScore");
            Debug.Log("Play: " + playVal);
            updateValue = GetPlayBarValue() + (0.025f * LightMovement.score)/4;
            PlayerPrefs.SetFloat("playBarBal", updateValue);
            SetPlayBarValue(updateValue);
        }

    }
}
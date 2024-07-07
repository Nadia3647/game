using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayBar : MonoBehaviour
{
    public static Image Bar;
    float value;
    float updateValue = 0.0f;

    private void Start()
    {
        Bar = GetComponent<Image>();
        updateValue = PlayerPrefs.GetFloat("playBarBal");
        Bar.fillAmount = updateValue;
    }

    public static void SetPlayBarValue(float value)
    {
        Bar.fillAmount = value;
    }
    public static float GetPlayBarValue()
    {
        return Bar.fillAmount;
    }
    public void Play()
    {
        updateValue = GetPlayBarValue() + 0.01f;
        PlayerPrefs.SetFloat("playBarBal", updateValue);
        SetPlayBarValue(updateValue);

    }
}
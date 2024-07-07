using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayBar : MonoBehaviour
{
    public static Image Bar;
    float value;

    private void Start()
    {
        Bar = GetComponent<Image>();
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

        SetPlayBarValue(GetPlayBarValue() + 0.01f);

    }
}
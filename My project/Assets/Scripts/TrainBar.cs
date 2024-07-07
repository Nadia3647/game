using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainBar : MonoBehaviour
{
    public static Image Bar;
    float value;
    float updateValue = 0.0f;

    private void Start()
    {
        Bar = GetComponent<Image>();
        updateValue = PlayerPrefs.GetFloat("trainBarBal");
        Bar.fillAmount = updateValue;

    }

    public static void SetTrainBarValue(float value)
    {
        Bar.fillAmount = value;
    }
    public static float GetTrainBarValue()
    {
        return Bar.fillAmount;
    }
    public void Train()
    {
        updateValue = GetTrainBarValue() + 0.01f;
        PlayerPrefs.SetFloat("trainBarBal",updateValue);
        SetTrainBarValue(updateValue);

    }
}
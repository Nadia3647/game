using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainBar : MonoBehaviour
{
    public static Image Bar;
    float value;

    private void Start()
    {
        Bar = GetComponent<Image>();
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

            SetTrainBarValue(GetTrainBarValue() + 0.01f);

    }
}
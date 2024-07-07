using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedBar : MonoBehaviour
{
    public static Image Bar;
    float value;

    private void Start()
    {
        Bar = GetComponent<Image>();
    }

    public static void SetFeedBarValue(float value)
    {
        Bar.fillAmount = value;
    }
    public static float GetFeedBarValue()
    {
        return Bar.fillAmount;
    }
    public static void Feed()
    {

        SetFeedBarValue(GetFeedBarValue() + 0.01f);

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class FeedBar : MonoBehaviour
{
    public static Image Bar;
    float value;
    static float updateValue = 0.0f;

    private void Start()
    {
        Bar = GetComponent<Image>();
        updateValue = PlayerPrefs.GetFloat("feedBarBal");
        Bar.fillAmount = updateValue;
        if (GameController.chek == 1)
        {
            Feed();
            GameController.chek = 0;
        }

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
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 1)
        {
            updateValue = GetFeedBarValue() + (0.0225f*Score.score)/4;
            PlayerPrefs.SetFloat("feedBarBal", updateValue);
            SetFeedBarValue(updateValue);
        }
    }

}

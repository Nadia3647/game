using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrainBar : MonoBehaviour
{
    public static Image Bar;
    float value;
    static float updateValue = 0.0f;

    private void Start()
    {
        Bar = GetComponent<Image>();
        updateValue = PlayerPrefs.GetFloat("trainBarBal");
        Bar.fillAmount = updateValue;
        if (Birds.chek == 1)
        {
            Train();
            Birds.chek = 0;
        }

    }

    public static void SetTrainBarValue(float value)
    {
        Bar.fillAmount = value;
    }
    public static float GetTrainBarValue()
    {
        return Bar.fillAmount;
    }
    public static void Train()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 1)
        {
            updateValue = GetTrainBarValue() + (0.03125f*DragonController.score)/4;
            PlayerPrefs.SetFloat("trainBarBal", updateValue);
            SetTrainBarValue(updateValue);
        }

    }
}
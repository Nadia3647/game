using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneClickTrain : MonoBehaviour
{
    public Button myButton; // Ссылка на вашу кнопку

    void Start()
    {
        // Проверка условия при старте
        CheckCondition();

    }


    void Update()
    {
        // Проверка условия в каждом кадре
        CheckCondition();
    }

    void CheckCondition()
    {
        if (Birds.played == 1)
        {
            myButton.interactable = false;
        }
        else
        {
            myButton.interactable = true;
        }
    }
}

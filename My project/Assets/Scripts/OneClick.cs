using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneClick : MonoBehaviour
{
    public Button myButton; // Ссылка на вашу кнопку
    public int conditionVariable; // Переменная условия

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
        // Делаем кнопку неактивной, если переменная равна 1
        if (GameController.played == 1)
        {
            myButton.interactable = false;
        }
        else
        {
            myButton.interactable = true;
        }
    }
}
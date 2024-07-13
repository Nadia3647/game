using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneClickTrain : MonoBehaviour
{
    public Button myButton; // ������ �� ���� ������

    void Start()
    {
        // �������� ������� ��� ������
        CheckCondition();

    }


    void Update()
    {
        // �������� ������� � ������ �����
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

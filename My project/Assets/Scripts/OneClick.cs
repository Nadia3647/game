using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneClick : MonoBehaviour
{
    public Button myButton; // ������ �� ���� ������
    public int conditionVariable; // ���������� �������

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
        // ������ ������ ����������, ���� ���������� ����� 1
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
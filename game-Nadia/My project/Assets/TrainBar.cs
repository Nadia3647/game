using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainBar : MonoBehaviour
{
    public static Image Bar;
    float value;
    private static float lastClickTime;
    // Start is called before the first frame update
    private void Start()
    {
        Bar = GetComponent<Image>();
        lastClickTime = -3600; // ����� ����� ����� ���� ������ ������ ����� ������� ����
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
        if (Time.time - lastClickTime > 3500) // ��������� ������ �� ������ ���� (3600 ������)
        {
            SetTrainBarValue(GetTrainBarValue() + 0.01f);
            lastClickTime = Time.time; // ��������� ����� ���������� �������
        }
    }
}

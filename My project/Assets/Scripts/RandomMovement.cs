using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomMovement : MonoBehaviour
{
    private RectTransform rectTransform;
    private Vector2 targetDirection;
    private RectTransform canvasRect;
    private float speed = 100f;

    void Start()
    {
        canvasRect = GetComponent<RectTransform>();
        rectTransform = GetComponent<RectTransform>();
        StartCoroutine(MoveRandomly());
    }

    IEnumerator MoveRandomly()
    {
        while (true)
        {
            // ���������� ����� ��������� ����������� ��� ��������
            targetDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;

            while (true)
            {
                // ������ ������� ������ � ����� �����������
                canvasRect.anchoredPosition += targetDirection * speed * Time.deltaTime;

                // ���������, ���� ������ ����� �� ������� canvas'�, ������ �����������
                if (!RectTransformUtility.RectangleContainsScreenPoint(canvasRect, canvasRect.position))
                {
                    targetDirection *= -1f;
                }

                yield return null;
            }
        }
    }

}

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
            // Генерируем новое случайное направление для движения
            targetDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;

            while (true)
            {
                // Плавно двигаем объект в новом направлении
                canvasRect.anchoredPosition += targetDirection * speed * Time.deltaTime;

                // Проверяем, если объект вышел за пределы canvas'а, меняем направление
                if (!RectTransformUtility.RectangleContainsScreenPoint(canvasRect, canvasRect.position))
                {
                    targetDirection *= -1f;
                }

                yield return null;
            }
        }
    }

}

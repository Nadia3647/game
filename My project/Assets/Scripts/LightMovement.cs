using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LightMovement : MonoBehaviour
{
    public GameObject fireflyPrefab;
    public Canvas canvas;
    private RectTransform canvasRect;
    private float timeLeft = 10;

    void Start()
    {
        canvasRect = canvas.GetComponent<RectTransform>();
        StartCoroutine(Spawn());
    }

    void FixedUpdate()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 0;
        }
    }

    IEnumerator Spawn()
    {
        while (timeLeft > 0)
        {
            Vector2 spawnPosition = new Vector2(
                Random.Range(-canvasRect.rect.width / 2, canvasRect.rect.width / 2),
                Random.Range(-canvasRect.rect.height / 2, canvasRect.rect.height / 2));
            GameObject newFirefly = Instantiate(fireflyPrefab, canvas.transform);
            newFirefly.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
            StartCoroutine(MoveRandomly(newFirefly.GetComponent<RectTransform>()));
            yield return new WaitForSeconds(Random.Range(0.3f, 0.7f));
        }
    }

    IEnumerator MoveRandomly(RectTransform objTransform)
    {
        Vector2 targetDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        float speed = 300f; // ������� �������� �������� ��������

        while (objTransform != null)
        {
            if (objTransform != null)
            {
                objTransform.anchoredPosition += targetDirection * speed * Time.deltaTime;

                if (!RectTransformUtility.RectangleContainsScreenPoint(canvasRect, objTransform.position))
                {
                    targetDirection *= -1f;
                }
            }

            yield return null;
        }
    }
    void ChangeVariable()
    {
        Vector2 targetDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }

}

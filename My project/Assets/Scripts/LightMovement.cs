using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LightMovement : MonoBehaviour
{
    public GameObject fireflyPrefab;
    public Canvas canvas;
    private RectTransform canvasRect;
    private float timeLeft = 60;
    public Text timerText;
    public static int chek;
    public static int score;
    private int lightCount = 0;
    private bool isPaused = false;

    void Start()
    {
        canvasRect = canvas.GetComponent<RectTransform>();
        StartCoroutine(Spawn());
        score = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }
    void UpdateText()
    {
        timerText.text = "Осталось:\n" + Mathf.RoundToInt(timeLeft);
    }

    void FixedUpdate()
    {
        if (!isPaused)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                timeLeft = 0;
                SceneManager.LoadScene(1);
                chek = 1;
            }
        }
    }

    IEnumerator Spawn()
    {
        while (timeLeft > 0 && lightCount < 40)
        {
            if (!isPaused)
            {
                Vector2 spawnPosition = new Vector2(
                    Random.Range(-canvasRect.rect.width / 2, canvasRect.rect.width / 2),
                    Random.Range(-canvasRect.rect.height / 2, canvasRect.rect.height / 2));
                GameObject newFirefly = Instantiate(fireflyPrefab, canvas.transform);
                newFirefly.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                StartCoroutine(MoveRandomly(newFirefly.GetComponent<RectTransform>()));
                lightCount++;
            }
            yield return new WaitForSeconds(Random.Range(0.3f, 0.7f));
        }
    }

    IEnumerator MoveRandomly(RectTransform objTransform)
    {
        Vector2 targetDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        float speed = 200f; // Укажите желаемую скорость движения

        while (objTransform != null)
        {
            if (!isPaused && objTransform != null)
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

    void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
    }
}


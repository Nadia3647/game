using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Birds : MonoBehaviour
{
    public GameObject birdPrefab;
    public GameObject coinPrefab;
    public Canvas canvas;
    public Text timerText;
    public float timeLeft;
    public static int chek;
    private float beefWidth;
    private RectTransform canvasRect;
    static float spawnX;
    private int coinCount = 0;
    private bool isPaused = false;
    private Coroutine spawnCoroutine1;
    private Coroutine spawnCoroutine2;

    void Start()
    {
        canvasRect = canvas.GetComponent<RectTransform>();
        beefWidth = birdPrefab.GetComponent<RectTransform>().rect.width;
        spawnCoroutine1 = StartCoroutine(Spawn1());
        spawnCoroutine2 = StartCoroutine(Spawn2());
        UpdateText();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                StopCoroutine(spawnCoroutine1);
                StopCoroutine(spawnCoroutine2);
                Time.timeScale = 0f; // останавливаем время
            }
            else
            {
                spawnCoroutine1 = StartCoroutine(Spawn1());
                spawnCoroutine2 = StartCoroutine(Spawn2());
                Time.timeScale = 1f; // возобновляем время
            }
        }

        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 0;
            chek = 1;
            Invoke("EndOfGame", 5);
        }
        UpdateText();
    }

    IEnumerator Spawn1()
    {
      
        while (timeLeft > 0)
        {
            float randomValue = Random.value;
            float randomValPref = Random.value;

            if (randomValue < 0.33f) // Выбираем левый край canvas
            {
                spawnX = -canvasRect.rect.width / 2 + beefWidth / 2;
            }
            else if (randomValue < 0.66f) // Выбираем середину canvas
            {
                spawnX = 0f;
            }
            else // Выбираем правый край canvas
            {
                spawnX = canvasRect.rect.width / 2 - beefWidth / 2;
            }

            float spawnY = canvasRect.rect.height / 2;
            Vector2 spawnPosition2 = new Vector2(spawnX, spawnY);
            
            GameObject newBeef = Instantiate(birdPrefab, canvas.transform);
            newBeef.GetComponent<RectTransform>().anchoredPosition = spawnPosition2;
            yield return new WaitForSeconds(2.0f);
        }
    }
    IEnumerator Spawn2()
    {

        while (timeLeft > 0 && coinCount < 32)
        {
            float spawnXCoin;
            GameObject pref;
            float randomValueCoin = Random.value;
            float randomValPref = Random.value;

            if (randomValueCoin < 0.33f) // Выбираем левый край canvas
            {
                spawnXCoin = -canvasRect.rect.width / 2 + beefWidth / 2;
            }
            else if (randomValueCoin < 0.66f) // Выбираем середину canvas
            {
                spawnXCoin = 0f;
            }
            else // Выбираем правый край canvas
            {
                spawnXCoin = canvasRect.rect.width / 2 - beefWidth / 2;
            }

            float spawnY = canvasRect.rect.height / 2;
            if (spawnXCoin != spawnX)
            {
                Debug.Log("Other: " + spawnX + " coin" + spawnXCoin);
                Vector2 spawnPosition2 = new Vector2(spawnXCoin, spawnY);

                GameObject newBeef = Instantiate(coinPrefab, canvas.transform);
                newBeef.GetComponent<RectTransform>().anchoredPosition = spawnPosition2;
                coinCount++;
                yield return new WaitForSeconds(2.0f);
            }
        }
    }
    void UpdateText()
    {
        timerText.text = "Осталось:\n" + Mathf.RoundToInt(timeLeft);
    }
    void EndOfGame()
    {
        SceneManager.LoadScene(1);

    }
}
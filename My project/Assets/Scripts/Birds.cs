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
    private static float spawnXBirdBefore = -1;
    private static float spawnX;
    private static float spawnXCoinBefore = -1;
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

            spawnX = RandomPosition();
            while (spawnX == spawnXBirdBefore)
            {
                spawnX = RandomPosition();
            }
            spawnXBirdBefore = spawnX;
            float spawnY = canvasRect.rect.height / 2;
            Vector2 spawnPosition2 = new Vector2(spawnX, spawnY);
            
            GameObject newBeef = Instantiate(birdPrefab, canvas.transform);
            newBeef.GetComponent<RectTransform>().anchoredPosition = spawnPosition2;
            yield return new WaitForSeconds(2.5f);
        }
    }
    float  RandomPosition()
    {
        float randomValue = Random.value;
        float spawn;

        if (randomValue < 0.33f) // Выбираем левый край canvas
        {
            spawn = -canvasRect.rect.width / 2 + beefWidth / 2;
        }
        else if (randomValue < 0.66f) // Выбираем середину canvas
        {
            spawn = 0f;
        }
        else // Выбираем правый край canvas
        {
            spawn = canvasRect.rect.width / 2 - beefWidth / 2;
        }
        return spawn;

    }
    IEnumerator Spawn2()
    {

        while (timeLeft > 0 && coinCount < 32)
        {
            float spawnXCoin = RandomPosition();
            while (spawnXCoin == spawnXCoinBefore)
            {
                spawnXCoin = RandomPosition();
            }
            spawnXCoinBefore = spawnXCoin;
            float spawnY = canvasRect.rect.height / 2;
            if (spawnXCoin != spawnX)
            {
                Debug.Log("Other: " + spawnX + " coin" + spawnX);
                Vector2 spawnPosition2 = new Vector2(spawnXCoin, spawnY);

                GameObject newBeef = Instantiate(coinPrefab, canvas.transform);
                newBeef.GetComponent<RectTransform>().anchoredPosition = spawnPosition2;
                coinCount++;
                yield return new WaitForSeconds(2.5f);
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
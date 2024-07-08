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
    private float beefWidth;
    private RectTransform canvasRect;



    void Start()
    {
        canvasRect = canvas.GetComponent<RectTransform>();
        beefWidth = birdPrefab.GetComponent<RectTransform>().rect.width;

        StartCoroutine(Spawn2());
        UpdateText();
    }

    void FixedUpdate()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 0;
            Invoke("EndOfGame", 5);
        }
        UpdateText();
    }

    IEnumerator Spawn2()
    {
      
        while (timeLeft > 0)
        {
            float spawnX;
            GameObject pref;
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
            if (randomValue > 0.5f) // Выбираем левый край canvas
            {
                pref = birdPrefab;
            }
            
            else // Выбираем правый край canvas
            {
                pref = coinPrefab;
            }
            GameObject newBeef = Instantiate(pref, canvas.transform);
            newBeef.transform.SetSiblingIndex(1);
            newBeef.GetComponent<RectTransform>().anchoredPosition = spawnPosition2;
            yield return new WaitForSeconds(Random.Range(3.0f, 8.5f));


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
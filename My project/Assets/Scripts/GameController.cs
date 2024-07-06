using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject beefPrefab;
    public GameObject burgerPrefab;
    public GameObject colaPrefab;
    public GameObject fricePrefab;
    public float timeLeft;
    public Text timerText;
    public Canvas canvas;
    private RectTransform canvasRect;
    private float beefWidth;

    void Start()
    {
        canvasRect = canvas.GetComponent<RectTransform>();
        beefWidth = beefPrefab.GetComponent<RectTransform>().rect.width;

        StartCoroutine(Spawn());
        UpdateText();
    }
    void FixedUpdate()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft<0)
        {
            timeLeft = 0;
        }
        UpdateText();
    }

    IEnumerator Spawn()
    {
        // Создание массива объектов
        GameObject[] objects = new GameObject[]{burgerPrefab,beefPrefab, colaPrefab, fricePrefab };


        yield return new WaitForSeconds(2.0f);
        while (timeLeft>0)
        {
            Vector2 spawnPosition = new Vector2(
                Random.Range(-canvasRect.rect.width / 2 + beefWidth / 2, canvasRect.rect.width / 2 - beefWidth / 2),
                Random.Range(-canvasRect.rect.height, canvasRect.rect.height));
            GameObject newBeef = Instantiate(objects[Random.Range(0, objects.Length)], canvas.transform);
            newBeef.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
            yield return new WaitForSeconds(Random.Range(1.0f, 2.0f));
        }
    }
    void UpdateText()
    {
        timerText.text = "Осталось:\n" + Mathf.RoundToInt(timeLeft);
    }
}
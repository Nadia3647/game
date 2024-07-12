using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject beefPrefab;
    public GameObject burgerPrefab;
    public GameObject colaPrefab;
    public GameObject fricePrefab;
    public static int chek;
    public float timeLeft;
    public Text timerText;
    public Canvas canvas;
    private RectTransform canvasRect;
    private float beefWidth;

    private int beefCount = 0;
    private int otherObjectsCount = 0;
    private bool isPaused = false;

    void Start()
    {
        canvasRect = canvas.GetComponent<RectTransform>();
        beefWidth = beefPrefab.GetComponent<RectTransform>().rect.width;

        StartCoroutine(Spawn1());
        StartCoroutine(Spawn2());
        UpdateText();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    void FixedUpdate()
    {
        if (!isPaused)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                timeLeft = 0;
                Invoke("EndOfGame", 5);
            }
            UpdateText();
        }
    }

    IEnumerator Spawn1()
    {
        GameObject[] objects = new GameObject[] { burgerPrefab, colaPrefab, fricePrefab };

        while (timeLeft > 0 && otherObjectsCount < 60)
        {
            if (!isPaused)
            {
                Vector2 spawnPosition = new Vector2(
                    Random.Range(-canvasRect.rect.width / 2 + beefWidth / 2, canvasRect.rect.width / 2 - beefWidth / 2),
                    canvasRect.rect.height / 2 - beefWidth * 2);
                GameObject newBadProduct = Instantiate(objects[Random.Range(0, objects.Length)], canvas.transform);
                newBadProduct.transform.SetSiblingIndex(1);
                newBadProduct.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
                otherObjectsCount++;
                Debug.Log("Other: " + otherObjectsCount);
            }
            yield return new WaitForSeconds(Random.Range(0.8f, 1.2f));
        }
    }

    IEnumerator Spawn2()
    {
        while (timeLeft > 0 && beefCount < 40)
        {
            if (!isPaused)
            {
                Vector2 spawnPosition2 = new Vector2(
                    Random.Range(-canvasRect.rect.width / 2 + beefWidth / 2, canvasRect.rect.width / 2 - beefWidth / 2),
                    canvasRect.rect.height / 2 - beefWidth * 2);
                GameObject newBeef = Instantiate(beefPrefab, canvas.transform);
                newBeef.transform.SetSiblingIndex(1);
                newBeef.GetComponent<RectTransform>().anchoredPosition = spawnPosition2;
                beefCount++;
                Debug.Log("Beef: " + beefCount);
            }
            yield return new WaitForSeconds(Random.Range(1.3f, 1.6f));
        }
    }

    void UpdateText()
    {
        timerText.text = "Осталось:\n" + Mathf.RoundToInt(timeLeft);
    }

    void EndOfGame()
    {
        SceneManager.LoadScene(1);
        chek = 1;
    }

    void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
    }
}
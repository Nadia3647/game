using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightMovement : MonoBehaviour
{
    public GameObject fireflyPrefab;
    public Canvas canvas;
    private RectTransform canvasRect;
    private float timeLeft=10;

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
            Random.Range(-canvasRect.rect.width / 2, canvasRect.rect.width / 2));
            GameObject newBadProduct = Instantiate(fireflyPrefab, canvas.transform);
            newBadProduct.GetComponent<RectTransform>().anchoredPosition = spawnPosition;
            yield return new WaitForSeconds(Random.Range(0.3f, 0.7f));

        }
    }
}

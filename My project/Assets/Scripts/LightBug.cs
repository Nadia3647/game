using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LightBug : MonoBehaviour, IPointerClickHandler
{
    int lightScore = 0;
    public void OnPointerClick(PointerEventData eventData)
    {
        lightScore++;
        Debug.Log("Clicked on: " + lightScore);
        PlayerPrefs.SetInt("lightScore", lightScore);
        Destroy(gameObject);
    }
}

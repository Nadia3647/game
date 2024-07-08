using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LightBug : MonoBehaviour, IPointerClickHandler
{
    int lightScore = 0;
    public void OnPointerClick(PointerEventData eventData)
    {
        PlayerPrefs.SetInt("lightScore", lightScore);
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LightFlyDestroy : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public void OnPointerClick(PointerEventData eventData)
    {
        Destroy(gameObject);
        IncrScore();
        
    }
    public static void IncrScore()
    {
        LightMovement.score += 1;
    }
}

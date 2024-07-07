using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LightBug : MonoBehaviour
{
    int score=0;

    void Update()

    {
        if (Input.GetMouseButtonDown(0) && EventSystem.current.IsPointerOverGameObject())
        {
            score++;
            Debug.Log("Score: " + score);
            Destroy(gameObject);
        }
    }

}

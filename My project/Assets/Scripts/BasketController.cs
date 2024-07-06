using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketController : MonoBehaviour
{
    public Camera cam;
    private float maxWidth;

    // Start is called before the first frame update
    void Start()
    {
        if (cam == null)
        {
            cam = Camera.main;
        }
        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
        maxWidth = targetWidth.x;
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        float targetX = Mathf.Clamp(transform.position.x + movement, 0, 600);
        Vector3 targetPosition = new Vector3(targetX, transform.position.y, transform.position.z);
        transform.position = targetPosition;
    }
}
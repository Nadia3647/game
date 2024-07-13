using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonController : MonoBehaviour
{
    public Camera cam;
    private float maxWidth;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
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
        float movement = Input.GetAxis("Horizontal")*10;
        float targetX = Mathf.Clamp(transform.position.x + movement, 0, 1920);
        Vector3 targetPosition = new Vector3(targetX, transform.position.y, transform.position.z);
        transform.position = targetPosition;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bird"))
        {
           SceneManager.LoadScene(1);
           Birds.played = 1;
           Birds.chek = 1;

        
        }
        else if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject); // ”ничтожение монеты после сбора
            score += 1;
        }
    }
}


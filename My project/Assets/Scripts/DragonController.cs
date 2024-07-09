using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 10.0f; // Увеличьте это значение для увеличения скорости перемещения

    private float direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.zero;
        rb.velocity = new Vector2(direction * moveSpeed * Time.fixedTime*50, 0);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bird"))
        {
           SceneManager.LoadScene(1);
        
        }
        else if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject); // Уничтожение монеты после сбора
        }
    }
}


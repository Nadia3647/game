using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInRacing : MonoBehaviour
{

    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0; // Отключаем стандартную гравитацию
    }

    void Update()
    {
        rb.velocity = new Vector2(0, -moveSpeed * Time.deltaTime);
    }
}

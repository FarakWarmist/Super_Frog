using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5f;
    public float jumpPower = 100f;
    SpriteRenderer spriteRenderer;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        var velocity = rb.velocity;
        velocity.x = speed * x;
        rb.velocity = velocity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpPower);
        }

        if (x != 0)
        {
            spriteRenderer.flipX = x < 0;
        }
    }
}

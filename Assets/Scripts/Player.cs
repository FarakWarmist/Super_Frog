using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera playerCam;
    Rigidbody2D rb;
    public float speed = 5f;
    public float jumpPower = 250f;
    SpriteRenderer spriteRenderer;
    public Vector3 initialPos;

    public float pv = 100f;
    public TMP_Text pvText;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerCam = Camera.main;
        initialPos = transform.position;
    }

    private void Update()
    {
        var camPos = playerCam.transform.position;
        camPos.x = transform.position.x;
        playerCam.transform.position = camPos;

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

        GameOver gameOver = FindAnyObjectByType<GameOver>();
        pv -= Time.deltaTime;
        pvText.text = $"PV: {(int)pv}";
        if (pv < 0)
        {
            gameOver.GetGameOver();
        }
    }

}

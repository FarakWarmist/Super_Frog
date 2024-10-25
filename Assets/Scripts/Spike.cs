using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);

        if (transform.position.y <= -10)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player player = FindAnyObjectByType<Player>();
        if (player != null)
        {
            player.pv -= 20;
            Destroy(gameObject);
        }
    }
}

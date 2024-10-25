using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melon : MonoBehaviour
{
    Player player;

    private void Start()
    {
        player = FindAnyObjectByType<Player>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (player != null)
        {
            player.pv += 20;
            if (player.pv > 100)
            {
                player.pv = 100;
            }
            Destroy(gameObject);
        }
    }
}

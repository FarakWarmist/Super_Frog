using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxyBox : MonoBehaviour
{
    private LineRenderer lineRenderer;
    Player player;
    private void Start()
    {
        player = FindAnyObjectByType<Player>();
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.enabled = false;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (player != null)
        {
            lineRenderer.enabled = true;
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, player.transform.position);
            player.pv += 10 * Time.deltaTime;
            if (player.pv > 100)
            {
                player.pv = 100;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (player != null)
        {
            lineRenderer.enabled = false;
        }
    }
}

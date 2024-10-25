using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    public GameObject spikePrefab;
    public float time = 1f;

    void Start()
    {
        InvokeRepeating("Spawn", 0, time);
    }

    // Update is called once per frame
    public void Spawn()
    {
        Instantiate(spikePrefab, transform.position, Quaternion.identity);
    }
}

using System;
using System.Numerics;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject projectile; 
    public GameObject island;
    float ticker = 0f;
    float ender = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Vector3 position = new UnityEngine.Vector3 (transform.position.x, UnityEngine.Random.Range(-3, 3), 0);
        ticker += Time.deltaTime;
        ender += Time.deltaTime;
        if (ticker >= 2f && ender<100)
        {
            Instantiate(projectile, position, transform.rotation);
            ticker = 0;
        }
        if (ender>=100)
        {
            ticker = -100000;
            Instantiate(island,transform.position, transform.rotation);
        }
    }
}

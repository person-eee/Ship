using System;
using System.Numerics;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject projectile; 
    float ticker = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Vector3 position = new UnityEngine.Vector3 (transform.position.x, UnityEngine.Random.Range(-3, 3), transform.position.z);
        ticker += Time.deltaTime;
        if (ticker >= 3.5f)
        {
            Instantiate(projectile, position, transform.rotation);
            ticker = 0;
        }
    }
}

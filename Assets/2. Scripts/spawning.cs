using System;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class Spawning : MonoBehaviour
{
    public GameObject projectile; 
    public GameObject island;
    public GameObject winText;
    private Canvas canvas;
    float ticker = 0f;
    float ender = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    canvas = FindAnyObjectByType<Canvas>();
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
        if (ender>=10)
        {
            ender = 0;
            Instantiate(island,transform.position, transform.rotation);
            Instantiate(winText, canvas.transform);
            Time.timeScale = 0;
        }
    }
}

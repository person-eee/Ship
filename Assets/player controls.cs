using System.Numerics;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assemblies;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    float speed = 5f;
    public Rigidbody2D movement;
    public GameObject projectile; 
    float ticker = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ticker += Time.deltaTime;
        float yPosition = transform.position.y;
        double min = -3.5;
        double max = 5;
        if (UnityEngine.Input.GetKeyDown(KeyCode.W) 
        || UnityEngine.Input.GetKeyDown(KeyCode.UpArrow))
        {
            movement.linearVelocity = UnityEngine.Vector2.up * speed;
        }
        if (UnityEngine.Input.GetKeyDown(KeyCode.S) 
        || UnityEngine.Input.GetKeyDown(KeyCode.DownArrow))
        {
            movement.linearVelocity = UnityEngine.Vector2.down * speed;
        }


        if (yPosition <= min)
        {
            movement.linearVelocityY = 1;
        }
        if (yPosition >= max)
        {
            movement.linearVelocityY = -1;
        }


        if (ticker >= 1.5f)
        {
            Instantiate(projectile, transform.position + transform.right * -2.5f, transform.rotation);
            ticker = 0;
        }
    }
}

using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assemblies;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    float speed = 5f;
    public Rigidbody2D movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 yPosition = transform.position;
        if (UnityEngine.Input.GetKeyDown(KeyCode.W) 
        || UnityEngine.Input.GetKeyDown(KeyCode.UpArrow))
        {
            movement.linearVelocity = (Vector2.up) * speed;
        }
        if (UnityEngine.Input.GetKeyDown(KeyCode.S) 
        || UnityEngine.Input.GetKeyDown(KeyCode.DownArrow))
        {
            movement.linearVelocity = (Vector2.down) * speed;
        }

    }
}

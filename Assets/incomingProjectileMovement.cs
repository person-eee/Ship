using UnityEngine;

public class missileMovement : MonoBehaviour
{
    public Rigidbody2D movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.linearVelocity = transform.right * -3f;
        if (transform.position.x > 20f)
        {
            Destroy(gameObject);
        }
    }
}

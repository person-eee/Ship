using UnityEngine;

public class missileMovement : MonoBehaviour
{
    float ticker = 0f;
    float interval = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ticker += Time.deltaTime;
        if(ticker >= interval){
        transform.Translate(Vector2.left * 1.25f);
        ticker = 0;
    };
        if (transform.position.x > 20f)
        {
            Destroy(gameObject);
        }
    }
}

using UnityEngine;

public class missileMovement : MonoBehaviour
{
    public Rigidbody2D projectileRigidbody;
    public GameObject endTextPrefab;
    private Canvas uiCanvas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        uiCanvas = FindAnyObjectByType<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        projectileRigidbody.linearVelocity = transform.right * -3f;
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
            UnityEngine.Object.Instantiate(endTextPrefab, uiCanvas.transform);
            Time.timeScale = 0;
        }
    }
}

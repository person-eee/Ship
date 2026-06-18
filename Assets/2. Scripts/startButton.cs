using UnityEngine;

public class startButton : MonoBehaviour
{
    public GameObject startScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0;
        startScreen.SetActive(true);

    }

    // Update is called once per frame
    public void StartButton()
    {
        startScreen.SetActive(false);
        Time.timeScale = 1;
    }
}

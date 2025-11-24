using UnityEngine;

public class Quit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        QuitGame();
    }
    void QuitGame()
    {
        Application.Quit();
        Debug.Log("This would have closed the game");
    }
}

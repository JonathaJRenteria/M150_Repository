using UnityEngine;

public class StartTimerScript : MonoBehaviour
{
    public GameManager gameManager; // Reference to the GameManager script

    void Start()
    {
        // Start the timer when your game begins
        gameManager.StartTimer();
    }
}

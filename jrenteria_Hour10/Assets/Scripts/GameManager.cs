using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;
    private bool isGameOver = false;

    private float elapsedTime = 0;
    private bool isRunning = false;

    void Update()
    {
        // If all four goals are solved, then the game is over
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;

        if (isRunning)
        {
            elapsedTime += Time.deltaTime; // Increment the elapsed time
        }

        // Check if the game is over
        if (isGameOver)
        {
            StopTimer(); // Stop the timer when the game is over
        }
    }

    void OnGUI()
    {
        if (isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");

            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");

            // Display the elapsed time in minutes and seconds
            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);
            Rect rect3 = new Rect(Screen.width / 2 - 100, Screen.height / 2 + 25, 200, 50);
            GUI.Label(rect3, "Time Taken: " + minutes.ToString("00") + ":" + seconds.ToString("00"));

            // Add a "Play Again" button
            Rect rect4 = new Rect(Screen.width / 2 - 60, Screen.height / 2 + 75, 120, 30);
            if (GUI.Button(rect4, "Play Again"))
            {
                // Reload the current scene to restart the game
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    public void StartTimer()
    {
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
    }
}

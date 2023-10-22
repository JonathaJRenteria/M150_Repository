using UnityEngine;

public class TimerScript : MonoBehaviour
{
    private float elapsedTime = 0f; // Elapsed time in seconds
    private bool isRunning = false;

    // Start the timer
    public void StartTimer()
    {
        isRunning = true;
    }

    // Stop the timer
    public void StopTimer()
    {
        isRunning = false;
    }

    // Get the elapsed time
    public float GetElapsedTime()
    {
        return elapsedTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
        }
    }
}

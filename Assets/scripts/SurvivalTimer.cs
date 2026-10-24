using UnityEngine;

public class SurvivalTimer : MonoBehaviour
{
    public float Elapsed { get; private set; }
    public bool IsRunning { get; private set; }

    public void StartTimer() { Elapsed = 0f; IsRunning = true; }
    public void StopTimer() { IsRunning = false; }

    private void Update()
    {
        if (IsRunning) Elapsed += Time.deltaTime;
    }
}

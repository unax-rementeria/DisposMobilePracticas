using TMPro;
using UnityEngine;

public class TimerUI : MonoBehaviour
{
    [SerializeField] private SurvivalTimer timer;
    [SerializeField] private TMP_Text currentText;
    [SerializeField] private TMP_Text bestText;

    private void Start()
    {
        float best = GameManager.Instance.RecordService.GetBestTime();
        bestText.text = "Mejor: " + Format(best);
    }

    private void Update()
    {
        currentText.text = Format(timer.Elapsed);
    }

    private static string Format(float seconds)
    {
        int m = (int)(seconds / 60f);
        float s = seconds % 60f;
        return $"{m:00}:{s:00.00}";
    }
}

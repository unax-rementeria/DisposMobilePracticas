using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    [SerializeField] private SurvivalTimer timer;

    [Header("Game Over UI")]
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TMP_Text finalTimeText;
    [SerializeField] private TMP_Text bestTimeText;
    [SerializeField] private GameObject newRecordText;
    [SerializeField] private GameObject activeTimer;
    [SerializeField] private GameObject activeBestTimer;


    private bool _isOver;

    private void Start()
    {
        Time.timeScale = 1f;
        gameOverPanel.SetActive(false);
        timer.StartTimer();
    }

    public void GameOver()
    {
        if (_isOver) return; // evita ejecutarlo dos veces si los dos vehículos chocan a la vez
        _isOver = true;

        timer.StopTimer();
        float time = timer.Elapsed;

        var records = GameManager.Instance.RecordService;
        bool isRecord = records.TrySubmitTime(time);

        finalTimeText.text = "Tiempo: " + Format(time);
        bestTimeText.text = "Mejor: " + Format(records.GetBestTime());
        newRecordText.SetActive(isRecord);
        activeTimer.SetActive(false);
        activeBestTimer.SetActive(false);
        gameOverPanel.SetActive(true);

        Time.timeScale = 0f;
    }

    public void TimeNormal()
    {
        Time.timeScale = 1f;
    }


    private static string Format(float seconds)
    {
        int m = (int)(seconds / 60f);
        float s = seconds % 60f;
        return $"{m:00}:{s:00.00}";
    }
}

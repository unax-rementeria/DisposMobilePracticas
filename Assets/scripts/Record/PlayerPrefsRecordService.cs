using UnityEngine;

public class PlayerPrefsRecordService : IRecordService
{
    private const string Key = "best_survival_time";

    public float GetBestTime() => PlayerPrefs.GetFloat(Key, 0f);

    public bool TrySubmitTime(float seconds)
    {
        if (seconds <= GetBestTime()) return false;
        PlayerPrefs.SetFloat(Key, seconds);
        PlayerPrefs.Save();
        return true;
    }
}

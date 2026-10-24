using UnityEngine;

public interface IRecordService
{
    float GetBestTime();
    bool TrySubmitTime(float seconds);
}

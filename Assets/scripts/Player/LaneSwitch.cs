using UnityEngine;

public class LaneSwitch : MonoBehaviour
{
    [SerializeField] private float leftLane = -1f;
    [SerializeField] private float rightLane = 1f;

    private bool _inLeftLane;

    private void Update()
    {
        float targetLane;
        if (_inLeftLane)
        {
            targetLane = leftLane;
        }
        else
        {
            targetLane = rightLane;
        }

        Vector2 pos = transform.position;
        pos.x = targetLane;
        transform.position = pos;
    }

    public void SwitchLane()  
    {
        _inLeftLane = !_inLeftLane;
    }
}

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

public class TouchInput : MonoBehaviour
{
    [SerializeField] private LaneSwitch leftVehicle;
    [SerializeField] private LaneSwitch rightVehicle;

    private void OnEnable()
    {
        EnhancedTouchSupport.Enable();
        Touch.onFingerDown += OnFingerDown;
    }

    private void OnDisable()
    {
        Touch.onFingerDown -= OnFingerDown;
        EnhancedTouchSupport.Disable();
    }

    private void OnFingerDown(Finger finger)
    {
        Debug.Log($"Toque en X: {finger.screenPosition.x}");
        bool leftHalf = finger.screenPosition.x < Screen.width * 0.5f;
        (leftHalf ? leftVehicle : rightVehicle).SwitchLane();
    }
}

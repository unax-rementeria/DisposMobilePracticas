using UnityEngine;

public class VehicleCollision : MonoBehaviour
{
    [SerializeField] private GameSession session;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Debug.Log("CHOQUE OH NO!!!");
            session.GameOver();
        }
    }
}

using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float Speed = 5f;
    void FixedUpdate()
    {
        transform.Translate(Vector2.down * Time.deltaTime * Speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Finish"))
            Destroy(this.gameObject);
    }
}

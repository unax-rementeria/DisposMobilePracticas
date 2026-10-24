using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform Spawn;
    public GameObject SpawnPrefab;
    public GameObject SpawnLinePrefab;
    private Vector2 leftSidePos = new Vector2(-0.5775f, 0);
    private Vector2 rightSidePos = new Vector2(0.5775f, 0);

    private float randomTimer;
    private float fixedTimer = 1f;

    void Start()
    {
        randomTimer = Random.Range(1f, 2f);
    }

    private void Update()
    {
        randomTimer -= Time.deltaTime;
        fixedTimer -= Time.deltaTime;

        if(fixedTimer <= 0)
        {
            LineSpawnMiddle();
            fixedTimer = 1f;
        }

        if (randomTimer <= 0)
        {
            RandomSideSpawn();
            randomTimer = Random.Range(0.5f, 2.5f);
        }
    }

    public void LineSpawnMiddle()
    {
        GameObject go = Instantiate(SpawnLinePrefab);
        go.transform.SetParent(Spawn);
        go.transform.localPosition = Vector2.zero;
    }

    public void RandomSideSpawn()
    {
        bool leftSide = Random.value < 0.5f;

        if (leftSide)
        {
            GameObject go = Instantiate(SpawnPrefab);
            go.transform.SetParent(Spawn);
            go.transform.localPosition = leftSidePos;
            
            Debug.Log("Left");
        }
        else
        {
            GameObject go = Instantiate(SpawnPrefab);
            go.transform.SetParent(Spawn);
            go.transform.localPosition = rightSidePos;

            Debug.Log("Right");
        }
    }
}

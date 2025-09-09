using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField] GameObject blockPrefab;
    [SerializeField] float spawnRate;
    [SerializeField] float minX;
    [SerializeField] float maxX;
    [SerializeField] float spawnY;

    void Start()
    {
        InvokeRepeating("SpawnBlock", 0, spawnRate);
    }

    void SpawnBlock()
    {
        Vector2 spawnPos = new Vector2(Random.Range(minX, maxX), spawnY);
        
        Instantiate(blockPrefab, spawnPos, Quaternion.identity);
    }

}

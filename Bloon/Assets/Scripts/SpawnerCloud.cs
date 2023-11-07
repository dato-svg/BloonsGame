using UnityEngine;

public class SpawnerCloud : MonoBehaviour
{
    [SerializeField] private GameObject[] Clund;
    [SerializeField] private float MinXposition;
    [SerializeField] private float MaxXposition;
    [SerializeField] private float MinYPosition;
    [SerializeField] private float MaxYPosition;
    [SerializeField] private float DelaySpawn;

    private void Start()
    {
        InvokeRepeating("SpawnCloud", 0, DelaySpawn);
    }

    private void SpawnCloud()
    {
        float randomX = Random.Range(MinXposition, MaxXposition);
        float randomY = Random.Range(MinYPosition, MaxYPosition);
        Vector3 spawnPosition = new Vector3(randomX, randomY, 0);

        GameObject cloud = Instantiate(Clund[Random.Range(0, Clund.Length)], spawnPosition, Quaternion.identity);
    }
}

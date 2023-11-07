using Unity.VisualScripting;
using UnityEngine;

public class SpawnerBloons : MonoBehaviour
{
    [SerializeField] private GameObject[] Bloons;
    [SerializeField] private float MinXposition;
    [SerializeField] private float MaxXposition;
    [SerializeField] private float YPosition;
    [SerializeField] private float DelaySpawn;

    private void Start()
    {
        InvokeRepeating("SpawnCloud", 0, DelaySpawn);
    }

    private void SpawnCloud()
    {
        float randomX = Random.Range(MinXposition, MaxXposition);
        Vector3 spawnPosition = new Vector3(randomX, YPosition, 0);

        GameObject cloud = Instantiate(Bloons[Random.Range(0, Bloons.Length)], spawnPosition, Quaternion.identity);
    }
}
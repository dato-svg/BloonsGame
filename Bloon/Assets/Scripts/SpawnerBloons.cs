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
        InvokeRepeating("SpawnCloud", 5, DelaySpawn);
    }

    private void SpawnCloud()
    {
        float randomX = Random.Range(MinXposition, MaxXposition);
        Vector3 spawnPosition = new Vector3(randomX, YPosition, 0);

        GameObject cloud = Instantiate(Bloons[Random.Range(0, Bloons.Length)], spawnPosition, Quaternion.identity);

        


    
    }


    public void KillEveryOne()
    {
        
        GameObject[] clouds = GameObject.FindGameObjectsWithTag("Bloons");

       
        foreach (GameObject cloud in clouds)
        {
            PlayerState.Score_Count++;
            cloud.gameObject.GetComponentInChildren<ParticleSystem>().Play();
            cloud.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            cloud.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            float Wai = 0;
            Wai += Time.deltaTime;
            if(Wai > 1)
            {
                Destroy(cloud);
            }
            
        }
    }


    public void KillEveryOneNoCount()
    {

        GameObject[] clouds = GameObject.FindGameObjectsWithTag("Bloons");


        foreach (GameObject cloud in clouds)
        {
           
            Destroy(cloud);
        }
    }
}

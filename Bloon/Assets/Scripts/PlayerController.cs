using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Camera Mcam;
    private PlayerState playerState;
    private AudioSource playerSource;

    private float WaitTime;

    private void Awake()
    {
        Mcam = GetComponent<Camera>();
        playerState = GetComponent<PlayerState>();
        playerSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f; 

        Vector2 worldMousePosition = Mcam.ScreenToWorldPoint(mousePosition);

        RaycastHit2D hit = Physics2D.Raycast(worldMousePosition, Vector2.zero);

        if (hit.collider != null && hit.collider.GetComponent<ControllerBloons>() != null)
        {   
            if(Input.GetMouseButtonDown(0))
            {
                WaitTime += Time.deltaTime;
                hit.collider.GetComponentInChildren<ParticleSystem>().Play();
                hit.collider.GetComponent<SpriteRenderer>().enabled = false;
                hit.collider.GetComponent<BoxCollider2D>().enabled = false;
                playerState.Score_Count++;
                playerSource.Play();
                playerState.Score_txt.text = playerState.Score_Count.ToString();



                if(WaitTime > 1)
                {
                    Destroy(hit.transform.gameObject);
                    WaitTime = 0;
                }
                
            }   
            
        }
    }
}

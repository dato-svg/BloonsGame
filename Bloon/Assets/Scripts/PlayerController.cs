using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Camera Mcam;

    private void Awake()
    {
        Mcam = GetComponent<Camera>();
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
                Destroy(hit.transform.gameObject);
            }   
            
        }
    }
}

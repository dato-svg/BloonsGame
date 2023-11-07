using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverer : MonoBehaviour
{
    [SerializeField] private GameObject GameOverPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<ControllerBloons>())
        {
            Destroy(collision.gameObject);
            
        }
    }
}

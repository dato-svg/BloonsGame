using UnityEngine;

public class ControllerBloons : MonoBehaviour
{
    [SerializeField] private float Speed;
    
    private Transform _Bloons;

    private void Awake()
    {
        _Bloons = GetComponent<Transform>();
    }

    private void Update()
    {
        _Bloons.Translate(Vector2.down * Time.deltaTime * Speed);
        
       
    }
}

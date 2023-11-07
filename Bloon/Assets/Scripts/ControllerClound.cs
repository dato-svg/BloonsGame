using UnityEngine;

public class ControllerClound : MonoBehaviour
{
    [SerializeField] private float MinSpeed;
    [SerializeField] private float MaxSpeed;

    [SerializeField] private float MinScale;
    [SerializeField] private float MaxScale;

    private float Timera;


    
    private Transform _Clund;

    private void Awake()
    {
        _Clund = GetComponent<Transform>();
    }

    private void Start()
    {
      _Clund.localScale = new Vector3(Random.Range(MinScale,MaxScale), Random.Range(MinScale, MaxScale), 0);
    }


    private void Update()
    {
        _Clund.Translate(Vector2.up * Time.deltaTime * Random.Range(MinSpeed,MaxSpeed));

        Timera += Time.deltaTime;
        if (Timera > 7)
        {
            Destroy(gameObject);
        }
    }

    

}

using UnityEngine;

public class Interactable : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 10);
    }
}

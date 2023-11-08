using TMPro;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public TextMeshProUGUI Score_txt;
    public static int Score_Count;


    private void Update()
    {
        Score_txt.text = Score_Count.ToString();
    }
}

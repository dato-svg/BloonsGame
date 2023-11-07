using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameOverer : MonoBehaviour
{
    [SerializeField] private GameObject GameOverPanel;
    [SerializeField] private SpawnerBloons spawnerBloons;
    [SerializeField] private GameObject PlayButton;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioSource BackgRound;
    private float timera;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<ControllerBloons>())
        {
            Destroy(collision.gameObject);
            GameOverPanel.SetActive(true);
            BackgRound.Stop();
            gameObject.GetComponent<BoxCollider2D>().enabled = false;

        }
    }


    public void Save()
    {   
        GameOverPanel.SetActive(false);
        spawnerBloons.KillEveryOne();
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        BackgRound.Play();


    }

    public void Restart()
    {
        audioSource.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        
        timera += Time.deltaTime;
        if(timera > 0.7f)
        {
            GameOverPanel.SetActive(false);
            timera = 0;
        }

    }

    public void PlayGame()
    {
        spawnerBloons.enabled = true;
        audioSource.Play();
        PlayButton.SetActive(false);
        


    }
}

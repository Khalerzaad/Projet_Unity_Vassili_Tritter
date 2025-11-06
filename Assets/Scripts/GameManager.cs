
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameWon = false;
    private AudioSource winSound;
    private float timeBeforeClose;
    [SerializeField] private float closingDelay = 5f;
    private float counter = 0f;
    void Awake()
    {
        winSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (gameWon)
        {
            if (counter > closingDelay)
            {
                SceneManager.LoadScene("Menu");
            }
            else
            {
                counter += Time.deltaTime;
            }
            timeBeforeClose = closingDelay - counter;
        }
    }
    public bool IsGameWon() => gameWon;
    public int TimeBeforeClose()
    {
        return Mathf.RoundToInt(timeBeforeClose);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        { 
            gameWon = true; 
            winSound.Play();
        }
    }
}

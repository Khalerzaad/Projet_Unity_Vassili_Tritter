using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem.Android;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class GameManager : MonoBehaviour
{
    private bool gameWon = false;
    private AudioSource winSound;
    private float timeBeforeClose;
    [SerializeField] private float closingDelay = 5f;
    void Awake()
    {
        winSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (gameWon)
        {
            float counter = 0f;
            if (counter > closingDelay)
            {
                Application.Quit();
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

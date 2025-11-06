using System.Runtime.CompilerServices;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    [SerializeField] private float coinRotationSpeed = 2f;
    [SerializeField] private float oscillationRange = 0.1f;
    [SerializeField] private float oscillationSpeed = 0.01f;
    private Vector3 initialPosition;
    private AudioSource coinSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialPosition = transform.position;
        coinSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {   
        transform.Rotate(0f, 0f, coinRotationSpeed);
        transform.position += Vector3.up * oscillationSpeed;
        if (transform.position.y > (initialPosition.y + oscillationRange) || transform.position.y < (initialPosition.y - oscillationRange)) 
        {
            oscillationSpeed = -oscillationSpeed;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // playsound and destroy coin
            coinSound.Play();
            Destroy(gameObject,coinSound.clip.length);
        }
    }
        
}

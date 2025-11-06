using UnityEngine;

public class DoorExplode : MonoBehaviour
{
    private Rigidbody door;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    door = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("ok");
            door.AddForce(collision.gameObject.transform.forward * 100);
        }
    }

}

using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    private float totalCoins;
    private float currentCoins = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        totalCoins = transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        currentCoins = totalCoins - transform.childCount;
    }
    public float ReturnCurrentCoinCount()
    {
        return currentCoins;
    }

    public float ReturnTotalCoins()
    {
        return totalCoins;
    }
}

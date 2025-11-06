using UnityEngine;

public class CollectibleDisplay : MonoBehaviour
{
    private TMPro.TMP_Text text;
    private string totalCoinsStr;
    private string currentCoinsStr;
    [SerializeField] private CollectibleManager coinCounter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        totalCoinsStr = coinCounter.ReturnTotalCoins().ToString();
        currentCoinsStr = coinCounter.ReturnCurrentCoinCount().ToString();
        text.text = $"Pièces récoltées : {currentCoinsStr} sur {totalCoinsStr}";
    }
}

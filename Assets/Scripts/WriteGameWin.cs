using UnityEngine;

public class WriteGameWin : MonoBehaviour
{
    [SerializeField] private GameManager endgame;
    private TMPro.TMP_Text text;
    private int closeDelay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (endgame == null) return;
        if (endgame.IsGameWon())
        {
            closeDelay = endgame.TimeBeforeClose();
            text.text = $"Félicitations !  Vous avez remporté la partie ! Fermeture dans {closeDelay}";
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour
{
    public Text coinText;
    private int coinCount;

    void Start()
    {
        if (coinText == null)
        {
            Debug.LogError("coinText is not assigned in the inspector!");
            return;
        }

        coinCount = PlayerPrefs.GetInt("CoinCount", 0);
        UpdateCoinText();
    }

    void Update()
    {
        int currentCoinCount = PlayerPrefs.GetInt("CoinCount", 0);
        if (coinCount != currentCoinCount)
        {
            coinCount = currentCoinCount;
            UpdateCoinText();
        }
    }

    private void UpdateCoinText()
    {
        if (coinText != null)
        {
            coinText.text = "Coins: " + coinCount.ToString();
        }
    }
}

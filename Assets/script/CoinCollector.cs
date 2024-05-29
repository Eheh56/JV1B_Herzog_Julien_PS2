using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private int coinCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            coinCount++;
            SaveCoins();
            Destroy(collision.gameObject);
        }
    }

    private void SaveCoins()
    {
        PlayerPrefs.SetInt("CoinCount", coinCount);
    }

    private void LoadCoins()
    {
        coinCount = PlayerPrefs.GetInt("CoinCount", 0);
    }

    private void Start()
    {
        LoadCoins();
    }
}
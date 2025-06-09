using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    // public static CoinCounter instance;
    public TMP_Text coinText;
    public int currentCoins = 0;
    public int maxCoinCount;
    public GameObject winPanel;
    void Awake()
    {
        winPanel = GameObject.Find("WinPanel");
    }
    void Start()
    {
        coinText.text = "Svinya: " + currentCoins.ToString();
        maxCoinCount = GameObject.FindGameObjectsWithTag("Yummy").Length;
        winPanel.SetActive(false);
    }
    public void IncreaseCoins(int v)
    {
        currentCoins += v;
        coinText.text = "Svinya: " + currentCoins.ToString();
        if (currentCoins == maxCoinCount)
        {
            winPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public int value;
    GameObject coinCounter;
    void Start()
    {
        coinCounter = GameObject.Find("CoinCounter");
    }
   private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Destroy this object when the player touches it
            Destroy(gameObject);
            coinCounter.GetComponent<CoinCounter>().IncreaseCoins(value);
        }
    }
}

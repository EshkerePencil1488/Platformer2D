using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnTouch : MonoBehaviour
{
    public string playerTag = "Player";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            // Option 1: Instantly destroy the player GameObject
            Destroy(other.gameObject);

            // Option 2: If you have a custom script with a Die() method
            // other.GetComponent<Health>()?.Die();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnTouch : MonoBehaviour
{
    public string playerTag = "Player";
    public GameObject restartButton;
    public Transform pointA, pointB;
    public float speed = 2f;   // Швидкість руху
    private Transform targetPoint;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            // Option 1: Instantly destroy the player GameObject
            Destroy(other.gameObject);
            restartButton.SetActive(true);

            // Option 2: If you have a custom script with a Die() method
            // other.GetComponent<Health>()?.Die();
        }
    }
    void Start()
    {
        targetPoint = pointA;  // Почати рух до точки B
    }

    void Update()
    {
        // Рух до цільової точки
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);
        // transform.position = new Vector3(transform.position.x, transform.position.y, 1);

        // Якщо досягнуто цільової точки — змінити напрямок
        if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f)
        {
            if (targetPoint == pointA)
                targetPoint = pointB;
            else
                targetPoint = pointA;
        }
    }
}

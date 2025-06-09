using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float Move;
    private Rigidbody2D rb2d;
    [SerializeField] public float jump;
    public GameObject restartButton;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        restartButton.SetActive(false);
    }
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(Move * speed, rb2d.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            rb2d.AddForce(new Vector2(rb2d.velocity.x, jump));
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("DeadZone"))
        {
            Destroy(gameObject);
            restartButton.SetActive(true);
        }
    }
}

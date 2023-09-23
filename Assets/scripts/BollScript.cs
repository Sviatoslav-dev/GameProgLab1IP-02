using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollScript : MonoBehaviour
{
    public float Speed = 0.1f;
    public float jumpAmount = 10f;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    } 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
        float moveX = Input.GetAxis("Horizontal");
        // rb.MovePosition(rb.position + Vector2.right * moveX * Speed * Time.deltaTime);
        rb.AddForce(Vector2.right * moveX * Speed, ForceMode2D.Impulse);
    }
}

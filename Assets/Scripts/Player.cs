using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;



    private float xInput;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        rb.linearVelocity = new Vector2(xInput * moveSpeed, rb.linearVelocityY);
        xInput = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, jumpForce);
        }
    }
}

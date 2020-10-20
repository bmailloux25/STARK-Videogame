using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D Rb;
    Vector2 movement;   // Store x,y
    public Animator animator;

    // Update is called once per frame
    void Update()   // Input
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()  // Movement
    {
        Rb.MovePosition(Rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}

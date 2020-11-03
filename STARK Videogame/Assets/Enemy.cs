using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;
    private Player player;
    private float moveSpeed;
    private Vector3 directionToPlayer;
    //private Vector3 localScale;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType(typeof(Player)) as Player;
        moveSpeed = 2f;
        //localScale = transform.localScale;
    }

    void update()
    {
        animator.SetFloat("Horizontal", directionToPlayer.x);
        animator.SetFloat("Vertical", directionToPlayer.y);
        animator.SetFloat("Speed", rb.velocity.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        moveCharacter();
    }

    private void moveCharacter()
    {
        directionToPlayer = (player.transform.position - transform.position).normalized;
        rb.velocity = new Vector2(directionToPlayer.x, directionToPlayer.y) * moveSpeed;
    }

    /*
    private void LateUpdate()
    {
        if (rb.velocity.x > 0)
        {
            transform.localScale = new Vector3(localScale.x, localScale.y, localScale.z);
        }
        else if (rb.velocity.x < 0)
        {
            transform.localScale = new Vector3(-localScale.x, localScale.y, localScale.z);
        }
    }
    */
}
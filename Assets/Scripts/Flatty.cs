using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flatty : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 10f;
    Vector2 Movement;
    private float moveInput;
    [SerializeField] private Animator animator;
    private bool facingRight = true;
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        if (facingRight == false && moveInput > 0)
        {
            flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            flip();
        }
        if (moveInput == 0)
        {
            animator.SetBool("IsRunning", false);
        }
        else
        {
            animator.SetBool("IsRunning", true);
        }
        Movement.x = Input.GetAxisRaw("Horizontal");

        rb.MovePosition(rb.position + Movement * moveSpeed * Time.fixedDeltaTime);
    }
    void flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}

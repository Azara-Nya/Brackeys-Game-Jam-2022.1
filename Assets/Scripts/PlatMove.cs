using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlatMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float JumpSpeed = 15;
    [SerializeField] private float JumpTime;
    [SerializeField] private float checkRadius;
    [SerializeField] private float coyoteTime;
    [SerializeField] private bool isGrounded = false;
    [SerializeField] private bool hitRoof = false;
    [SerializeField] private Transform feetPos;
    [SerializeField] private Transform headPos;
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private Animator animator;
    [SerializeField] AudioSource JumpSFX;
    private float JumpTimeCounter;
    private float coyoteTimer;
    private bool isJumping;
    private float moveInput;
    private float jumpBufferCounter;
    private float jumpBufferTime = 0.2f;
    private bool facingRight = true;
    Vector2 movement;

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
        if (isGrounded)
        {
            coyoteTimer = coyoteTime;
        }
        else
        {
            coyoteTimer -= Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

            jumpBufferCounter = jumpBufferTime;
            JumpSFX.Play();
        }
        else
        {
            jumpBufferCounter -= Time.deltaTime;
        }

        movement.x = Input.GetAxisRaw("Horizontal");
        if (coyoteTimer > 0f && jumpBufferCounter > 0f)
        {
            JumpTimeCounter = JumpTime;
            coyoteTimer = coyoteTime;
            isJumping = true;
            rb.velocity = Vector2.up * JumpSpeed;
            jumpBufferCounter = 0f;
        }
        if (Input.GetKey(KeyCode.Space) && isJumping)
        {
            if (JumpTimeCounter > 0 && coyoteTimer > 0)
            {
                rb.velocity = Vector2.up * JumpSpeed;
                JumpTimeCounter -= Time.deltaTime;
                coyoteTimer -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }
        if (hitRoof)
        {
            JumpTimeCounter = 0;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            JumpSFX.Stop();
            isJumping = false;
            coyoteTimer = 0f;
        }
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        hitRoof = Physics2D.OverlapCircle(headPos.position, checkRadius, whatIsGround);
    }
    void flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }
}


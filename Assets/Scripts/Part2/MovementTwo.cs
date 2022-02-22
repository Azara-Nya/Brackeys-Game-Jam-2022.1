using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTwo : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 10f;
    Vector2 Movement;
    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");

        rb.MovePosition(rb.position + Movement * moveSpeed * Time.fixedDeltaTime);
    }
}
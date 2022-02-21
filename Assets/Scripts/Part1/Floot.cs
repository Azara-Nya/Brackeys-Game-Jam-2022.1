using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floot : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private bool counter = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (counter == false)
            {
                StartCoroutine(Grav());
            }
        }
    }

    IEnumerator Grav()
    {
        rb.gravityScale = 0.5f;
        yield return new WaitForSeconds(5f);
        rb.gravityScale = 3f;
        counter = true;
    }
}

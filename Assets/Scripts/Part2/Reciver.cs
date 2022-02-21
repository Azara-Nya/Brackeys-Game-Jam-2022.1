using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reciver : MonoBehaviour
{
    [SerializeField] private bool IsBlue = false;
    [SerializeField] private bool IsRed = false;
    [SerializeField] private BoxManager BM;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Box"))
        {
            if (IsBlue == false && IsRed == false)
            {
                BM.Normal -= 1;
            }
        }

        if (other.CompareTag("BoxRed") && IsRed)
        {
            BM.Red -= 1;
        }

        if (other.CompareTag("BoxBlue") && IsBlue)
        {
            BM.Blue -= 1;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("Box"))
        {
            if (IsBlue == false && IsRed == false)
            {
                BM.Normal += 1;
            }
        }

        if (other.CompareTag("BoxRed") && IsRed)
        {
            BM.Red += 1;
        }

        if (other.CompareTag("BoxBlue") && IsBlue)
        {
            BM.Blue += 1;
        }
    }
}

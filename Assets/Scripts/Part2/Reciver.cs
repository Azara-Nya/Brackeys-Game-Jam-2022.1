using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Reciver : MonoBehaviour
{
    [SerializeField] private bool IsBlue = false;
    [SerializeField] private bool IsRed = false;
    [SerializeField] private BoxManager BM;
    [SerializeField] AudioSource BoxSFX;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Box"))
        {
            if (IsBlue == false && IsRed == false)
            {
                BM.Normal -= 1;
                StartCoroutine(SFX());
            }
        }

        if (other.CompareTag("BoxRed") && IsRed)
        {
            BM.Red -= 1;
            StartCoroutine(SFX());
        }

        if (other.CompareTag("BoxBlue") && IsBlue)
        {
            BM.Blue -= 1;
            StartCoroutine(SFX());
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("Box"))
        {
            if (IsBlue == false && IsRed == false)
            {
                BM.Normal += 1;
                BoxSFX.Stop();
            }
        }

        if (other.CompareTag("BoxRed") && IsRed)
        {
            BM.Red += 1;
            BoxSFX.Stop();
        }

        if (other.CompareTag("BoxBlue") && IsBlue)
        {
            BM.Blue += 1;
            BoxSFX.Stop();
        }
    }

    IEnumerator SFX()
    {
        yield return new WaitForSeconds(0f);
        BoxSFX.Play();
    }
}

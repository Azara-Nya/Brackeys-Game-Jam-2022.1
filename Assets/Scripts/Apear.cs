using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apear : MonoBehaviour
{
    [SerializeField] private GameObject Tex;
    void Start()
    {
        Tex.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Tex.SetActive(true);
            //Would be better to start animation trigger
        }
    }
}

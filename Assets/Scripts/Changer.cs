using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer : MonoBehaviour
{
    [SerializeField] private bool one;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (one)
            {
                GameObject.Find("BoolBacker").GetComponent<BoolBacker>().keeper[0] = true;
            }
            else
            {
                GameObject.Find("BoolBacker").GetComponent<BoolBacker>().keeper[1] = true;
            }
        }
    }
}

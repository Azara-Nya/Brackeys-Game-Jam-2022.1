using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressTracker : MonoBehaviour
{
    [SerializeField] private GameObject[] photos;
    [SerializeField] private GameObject[] voidPhotos;
    public bool[] photosUnlock;


    void Update()
    {
        if (photosUnlock[1])
        {
            photos[1].SetActive(true);
            voidPhotos[0].SetActive(false);
        }
        else
        {
            photos[1].SetActive(false);
            voidPhotos[0].SetActive(true);
        }

        if (photosUnlock[2])
        {
            photos[2].SetActive(true);
            voidPhotos[1].SetActive(false);
        }
        else
        {
            photos[2].SetActive(false);
            voidPhotos[1].SetActive(true);
        }
    }
}

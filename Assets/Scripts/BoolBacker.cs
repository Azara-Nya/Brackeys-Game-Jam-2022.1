using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolBacker : MonoBehaviour
{
    public bool[] keeper;


    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        if (keeper[0] == true)
        {
            GameObject.Find("Progress Tracker").GetComponent<ProgressTracker>().photosUnlock[1] = true;
        }
        else
        {
            GameObject.Find("Progress Tracker").GetComponent<ProgressTracker>().photosUnlock[1] = false;
        }
        if (keeper[1] == true)
        {
            GameObject.Find("Progress Tracker").GetComponent<ProgressTracker>().photosUnlock[2] = true;
        }
        else
        {
            GameObject.Find("Progress Tracker").GetComponent<ProgressTracker>().photosUnlock[2] = false;
        }
    }
}

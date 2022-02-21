using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxManager : MonoBehaviour
{
    public float Normal;
    public float Red;
    public float Blue;
    [SerializeField] private float total;
    [SerializeField] private float transtionTime = 1f;
    [SerializeField] private string Level;
    void Update()
    {
        total = Normal + Red + Blue;

        if (total <= 0)
        {
            StartCoroutine(Loader(Level));
        }
    }

    IEnumerator Loader(string Gary)
    {
        // transtion.SetTrigger("StartFade");
        yield return new WaitForSeconds(transtionTime);

        SceneManager.LoadScene(Gary);
    }
}

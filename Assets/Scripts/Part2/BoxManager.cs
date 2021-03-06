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
    [SerializeField] private GameObject Text;
    [SerializeField] private float TextTime = 2f;
    [SerializeField] private Animator transtion;
    [SerializeField] private bool five = false;

    void Start()
    {
        Text.SetActive(false);
    }
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
        if (!five)
        {
            //Better with animation
            Text.SetActive(true);
            yield return new WaitForSeconds(TextTime);
            transtion.SetTrigger("StartFade");
            yield return new WaitForSeconds(transtionTime);

            SceneManager.LoadScene(Gary);
        }
        else
        {
            //Better with animation
            Text.SetActive(true);
            yield return new WaitForSeconds(TextTime);
            transtion.SetTrigger("StartFadeWhite");
            yield return new WaitForSeconds(transtionTime);

            SceneManager.LoadScene(Gary);
        }
    }
}

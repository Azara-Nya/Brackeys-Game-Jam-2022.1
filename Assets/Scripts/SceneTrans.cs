using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrans : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;
    [SerializeField] private Vector2 playerPosition;
    [SerializeField] private Animator transtion;
    [SerializeField] private Animator Self;
    [SerializeField] private Animator Camera;
    [SerializeField] private float transtionTime = 1f;
    [SerializeField] private bool five = false;
    [SerializeField] private bool two;
    [SerializeField] private bool three;
    [SerializeField] private bool four;
    [SerializeField] private bool one;
    [SerializeField] private float CamTim;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            LoadNextScene();
        }
    }

    public void LoadNextScene()
    {
        StartCoroutine(LoadLevel(sceneToLoad));
    }

    IEnumerator LoadLevel(string Gary)
    {
        if (!five)
        {
            if (one)
            {
                Self.SetTrigger("Walk");
            }
            if (two)
            {
                Self.SetTrigger("Walk2");
            }
            if (three)
            {
                Self.SetTrigger("Walk3");
            }
            if (four)
            {
                Self.SetTrigger("Walk4");
            }
            transtion.SetTrigger("StartFade");
            yield return new WaitForSeconds(transtionTime);

            SceneManager.LoadScene(Gary);
        }
        else
        {
            Self.SetTrigger("Walk5");
            Camera.SetTrigger("Stert");
            yield return new WaitForSeconds(CamTim);
            transtion.SetTrigger("StartFadeWhite");
            yield return new WaitForSeconds(transtionTime);

            SceneManager.LoadScene(Gary);
        }
    }
}

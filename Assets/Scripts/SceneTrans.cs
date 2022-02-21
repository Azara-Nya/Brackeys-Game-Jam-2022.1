using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrans : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;
    [SerializeField] private Vector2 playerPosition;
    [SerializeField] private Animator transtion;
    // [SerializeField] private Animator Self;
    [SerializeField] private float transtionTime = 1f;
    [SerializeField] private bool five = false;


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
            //Self.SetTrigger("Run");
            //yield return new WaitForSeconds(transtionTime);
            transtion.SetTrigger("StartFade");
            yield return new WaitForSeconds(transtionTime);

            SceneManager.LoadScene(Gary);
        }
        else
        {
            //Self.SetTrigger("Run");
            //yield return new WaitForSeconds(transtionTime);
            transtion.SetTrigger("StartFadeWhite");
            yield return new WaitForSeconds(transtionTime);

            SceneManager.LoadScene(Gary);
        }
    }
}

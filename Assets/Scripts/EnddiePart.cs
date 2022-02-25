using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnddiePart : MonoBehaviour
{
    [SerializeField] private Animator trans;
    [SerializeField] private Animator CamTrans;
    [SerializeField] private string Level = "MainMenu";
    [SerializeField] private float TransTime = 10f;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Endye"))
        {
            StartCoroutine(EnddiePar(Level));
        }
    }

    IEnumerator EnddiePar(string gary)
    {
        trans.SetTrigger("ye");
        CamTrans.SetTrigger("yes");
        yield return new WaitForSeconds(TransTime);
        SceneManager.LoadScene(gary);
    }
}

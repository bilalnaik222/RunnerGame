using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{

    [SerializeField] GameObject fadeout;
    public void startGame()
    {
        StartCoroutine(startfade());
    }

    IEnumerator startfade()
    {
        fadeout.SetActive(true);
         yield return new WaitForSeconds(1);
         SceneManager.LoadScene(0);
    }
}

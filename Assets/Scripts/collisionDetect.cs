using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionDetect : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] GameObject playeranima;
    [SerializeField] AudioSource collioneffect;
    [SerializeField] GameObject fadeout;
    [SerializeField] GameObject maincam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(collisionend());
    }

    IEnumerator collisionend()
    {
        collioneffect.Play();
        player.GetComponent<playerMovement>().enabled = false;
        playeranima.GetComponent<Animator>().Play("Stumble Backwards");
        maincam.GetComponent<Animator>().Play("CollionAnimation");
        yield return new WaitForSeconds(3);
        fadeout.SetActive(true);
          yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
    
}

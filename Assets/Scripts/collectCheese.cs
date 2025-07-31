using UnityEngine;

public class collectCheese : MonoBehaviour
{

    [SerializeField] AudioSource cheesefx;

    void OnTriggerEnter(Collider other)
    {
        cheesefx.Play();
        this.gameObject.SetActive(false);
        PointsCount.pointcount += 1;
    }
}

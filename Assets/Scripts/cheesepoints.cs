using UnityEngine;

public class cheesepoints : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] int rotationspeed = 1;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0,rotationspeed);
    }
}

using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float playerSpeed = 6f;
    public float horizontalSpeed = 7f;
    public float leftLimit = -5.5f;
    public float rightLimit = 5.5f;

    private int lastSpeedIncreasePoints = 0; // Track last 10-point milestone

    void Update()
    {
        // Check if points reached the next 10-point milestone
        if (PointsCount.pointcount >= lastSpeedIncreasePoints + 10)
        {
            playerSpeed += 1f;        // Increase forward speed by 1
            horizontalSpeed += 1f;    // Increase horizontal speed by 1
            lastSpeedIncreasePoints = PointsCount.pointcount - (PointsCount.pointcount % 10);
        }

        // Move forward
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);

        float x = transform.position.x;

        // Move Left
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && x > leftLimit)
        {
            transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed, Space.World);
        }

        // Move Right
        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && x < rightLimit)
        {
            transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed, Space.World);
        }
    }
}

using UnityEngine;

public class CameraScript : MonoBehaviour
{

    float distance = 10;
    float angleX = 30f;  // Camera tilt angle around the X-axis
    float angleY = 45f;  // Camera rotation angle around the Y-axis
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Convert angles to radians
        float radX = angleX * Mathf.Deg2Rad;
        float radY = angleY * Mathf.Deg2Rad;

        // Compute the camera's position
        float x = distance * Mathf.Cos(radY) * Mathf.Cos(radX);
        float y = distance * Mathf.Sin(radX);
        float z = distance * Mathf.Sin(radY) * Mathf.Cos(radX);

        // Set the camera's position
        Vector3 offset = new Vector3(x, y, z);

        transform.position = player.position + offset;
        
    }

    // Update is called once per frame
    void Update()
    {
        // Convert angles to radians
        float radX = angleX * Mathf.Deg2Rad;
        float radY = angleY * Mathf.Deg2Rad;

        // Compute the camera's position
        float x = distance * Mathf.Cos(radY) * Mathf.Cos(radX);
        float y = distance * Mathf.Sin(radX);
        float z = distance * Mathf.Sin(radY) * Mathf.Cos(radX);

        // Set the camera's position
        Vector3 offset = new Vector3(-x, y, -z);

        transform.position = player.position + offset;
    }
}

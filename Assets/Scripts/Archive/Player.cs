using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update ()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 user_input = new Vector3(horizontal,0,vertical);
        

        // Rotation matrix for 45 degrees about the Y axis
        float cos45 = Mathf.Sqrt(2) / 2;
        float sin45 = Mathf.Sqrt(2) / 2;

        // Matrix multiplication
        Vector3 rotatedVector = new Vector3(
            cos45 * user_input.x + sin45 * user_input.z,   // x'
            user_input.y,                          // y' (unchanged)
            -sin45 * user_input.x + cos45 * user_input.z   // z'
        );

        transform.position += rotatedVector.normalized * speed * Time.deltaTime;

        //Debug.Log("Rotated Vector: " + rotatedVector);
    }
}

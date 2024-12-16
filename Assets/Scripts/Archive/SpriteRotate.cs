using UnityEngine;

public class SpriteRotate : MonoBehaviour
{
    Camera mainCamera;
    void Start()
    {
        mainCamera = Camera.main;
        transform.rotation = mainCamera.transform.rotation;

    }

    void LateUpdate()
    {
    }
}

using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 dir;
    public float speed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    public void SetDir(Transform player_transform){
        dir = (player_transform.position - transform.position).normalized;
    }
}

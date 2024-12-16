using UnityEngine;

public class Luigi : MonoBehaviour
{
    public float shot_cadence = 5;

    public Transform player;
    public GameObject bullet;

    float time_since_last_shot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time_since_last_shot = 0;
    }

    // Update is called once per frame

    void FixedUpdate()
    {
        if (time_since_last_shot >= shot_cadence){
            GameObject b = Instantiate(bullet, transform.position, Quaternion.identity);
            b.GetComponent<Bullet>().SetDir(player);
            time_since_last_shot = 0;
        }
        time_since_last_shot += Time.deltaTime;
    }


}

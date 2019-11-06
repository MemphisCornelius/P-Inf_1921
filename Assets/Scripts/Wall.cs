using UnityEngine;

public class Wall : MonoBehaviour
{
    Transform player;
    float time = 5.0f;

    void Awake()
    {
        player = GameObject.Find("Player").transform;
        Vector3 difference = player.transform.position - transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ - 90);

    }
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            Destroy(gameObject);
        }
    }
}
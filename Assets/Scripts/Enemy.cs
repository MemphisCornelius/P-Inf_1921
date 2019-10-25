using UnityEngine;
 
public class Enemy : MonoBehaviour {
    public float speed;
    public float retspeed;
    public float retDis;
    public float stopDis;

    private Transform player;
    public GameObject destroyEffect;
    public float hp = 100f;
    public Rigidbody2D rb;

    private float timeBtwShots;
    public float startTimeBtwShots;

    void Start()
    {
        player = GameObject.Find("Player").transform;
        timeBtwShots = startTimeBtwShots;
    }

    void fireBullet(Vector2 direction, float rotationZ)
    {

    }

    void FixedUpdate()
    {
        float dist = Vector3.Distance(transform.position, player.transform.position);
        Vector3 difference = player.transform.position - transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

        if (Vector2.Distance(transform.position, player.position) > stopDis)
        {
            transform.position = Vector2.Lerp(transform.position, player.position, speed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, player.position) > retDis && Vector2.Distance(transform.position, player.position) < stopDis)
        {
            rb.velocity = new Vector2(0, 0);

        }
        else if (Vector2.Distance(transform.position, player.position) <= retDis)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, -retspeed * Time.deltaTime);
        }
        
        if (timeBtwShots <= 0)
        {
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            fireBullet(direction, rotationZ);

            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        /*if (collision.collider.name == "Projectile(Clone)")
        {
            hp -= GameObject.Find("Projectile(Clone)").GetComponent<Projectile>().damage;
        }*/
        if (hp <= 0)
        {
            Instantiate(destroyEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
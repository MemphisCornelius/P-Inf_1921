using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Minigame : MonoBehaviour
{
    public int speed;
    public Rigidbody2D rb;
    float xForce, yForce;
    public float maxSpeed;
    private Vector3 target;
    public bool Movementenabled = true;
    public GameObject Health_1;
    public GameObject Health_2;

    public Camera camera;

    Vector2 mousePosition;

    void FixedUpdate()
    {

        if (Movementenabled == true)
        {
            float xInput = Input.GetAxis("Horizontal");
            float yInput = Input.GetAxis("Vertical");
            xForce = xInput * speed * Time.deltaTime;
            yForce = yInput * speed * Time.deltaTime;
            Vector2 force = new Vector2(xForce, yForce);
            rb.velocity = force;
            if (rb.velocity.magnitude > maxSpeed)
            {
                rb.velocity = rb.velocity.normalized * maxSpeed;
            }
            if (Input.GetAxis("Vertical") == 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, 0);
            }
            if (Input.GetAxis("Horizontal") == 0)
            {
                rb.velocity = new Vector2(0, rb.velocity.y);
            }
            target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));

            Vector3 difference = target - transform.position;

            mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);

            Vector2 Direction = mousePosition - rb.position;

            float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg - 90f;

            rb.rotation = angle;

        }

        int Health = gameObject.GetComponent<Health_and_Damage>().Health;

        if (Health <= 50)
        {
            Health_1.SetActive(false);

            if (Health <= 25)
            {
                Health_2.SetActive(false);
            }
        }

    }


}

using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public int speed;
    public Rigidbody2D rb;
    float xForce, yForce;
    public float maxSpeed;
    private Vector3 target;

    void FixedUpdate() {
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
       
     
    }
}
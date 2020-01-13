using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Interact : MonoBehaviour {
    public UnityEvent interact;
    
    public float radius = 1.5f, dist;
    public GameObject player;
    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKeyDown("e")) {
            Test();
        }
    }
    void Update() {
        dist = Vector3.Distance(transform.position, player.transform.position);
        Test();
    }

    private void Test() {
        if (Input.GetKeyDown("e") && dist < radius)
        {
            interact.Invoke();
            //player.GetComponent<PlayerMovement>().Movementenabled = true;
            //player.GetComponent<PlayerMovement>().Movementenabled = false;
            //player.transform.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}
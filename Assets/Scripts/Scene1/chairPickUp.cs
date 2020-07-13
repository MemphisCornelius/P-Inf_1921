using UnityEngine;

public class chairPickUp : MonoBehaviour {

    public float maxdis;
    public GameObject player, zettel;
    private bool chairUp = false, zettelFallen = false;
    private float timer, timer1;
    Animator animator;
    void Start() {
        animator = GetComponent<Animator>();
    }

    void Update() {
        float dist = Vector3.Distance(transform.position, player.transform.position);
        if (Input.GetKeyDown("e") && chairUp){
            player.GetComponent<Animator>().SetBool("Chair?", false);
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z) + new Vector3(Mathf.Cos(0),Mathf.Sin(0), 0);
            timer = 1f;
            chairUp = false;
        }
        timer = timer - Time.deltaTime;
        timer1 = timer1 - Time.deltaTime;
        if (Input.GetKeyDown("e") && dist < maxdis && !chairUp && timer <= 0) {
            player.GetComponent<Animator>().SetBool("Chair?",true);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            timer1 = 1f;
            chairUp = true;
            
        }
        if (timer1 <= 0 && chairUp)
        {
            zettel.GetComponent<Interact>().enabled = true;
            zettel.GetComponent<SpriteRenderer>().enabled = true;
            zettelFallen = true;

        }
        else if (!zettelFallen){
            zettel.transform.position = new Vector2 (player.transform.position.x, player.transform.position.y);
        }
    }
}
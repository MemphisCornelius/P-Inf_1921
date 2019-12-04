using UnityEngine;

public class chairPickUpScript : MonoBehaviour {

    public float maxdis;
    public GameObject player, zettel;
    private bool chairUp = false, zettelFallen = false;
    private float timer, timer1;
    private Vector3 target;
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        float dist = Vector3.Distance(transform.position, player.transform.position);
        if (Input.GetKeyDown("e") && chairUp){
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            Vector3 difference = player.transform.position - transform.position;
            target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1000));
            Vector3 dif = target - transform.position;
            //float rotation = Mathf.Atan2(dif.y, dif.x) * Mathf.Rad2Deg;
            transform.position = new Vector2(player.transform.position.x, player.transform.position.y) + new Vector2(Mathf.Cos(0),Mathf.Sin(0));
            timer = 1f;
            chairUp = false;
        }
        timer = timer - Time.deltaTime;
        timer1 = timer1 - Time.deltaTime;
        if (Input.GetKeyDown("e") && dist < maxdis && !chairUp && timer <= 0) {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            timer1 = 1f;
            chairUp = true;
            
        }
        if (timer1 <= 0 && chairUp)
        {
            zettel.GetComponent<Interact>().enabled = true;
            zettel.GetComponent<MeshRenderer>().enabled = true;
            zettelFallen = true;

        }
        else if (!zettelFallen){
            zettel.transform.position = new Vector2 (player.transform.position.x, player.transform.position.y);
        }
    }
}
 using UnityEngine;

public class FernseherRauschen : MonoBehaviour
{
    public GameObject fernseher, player;
    public float radius;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.transform.position);
        if (Input.GetKeyDown("e") && dist < radius && player.GetComponent<PlayerMovement>().Movementenabled)
        {
            fernseher.GetComponent<SpriteRenderer>().color = new Vector4(0, 1, 0, 1);
            player.GetComponent<PlayerMovement>().Movementenabled = false;

        } else if (Input.GetKeyDown("e") && dist < radius && !player.GetComponent<PlayerMovement>().Movementenabled)
        {
            player.GetComponent<PlayerMovement>().Movementenabled = true;
        }
    }
}
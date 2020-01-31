 using UnityEngine;

public class FernseherRauschen : MonoBehaviour
{
    public GameObject fernseher, player, licht;
    public float radius;
    public bool zettel = false;
    bool flackern = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.transform.position);
        if (Input.GetKeyDown("e") && dist < radius && player.GetComponent<PlayerMovement>().Movementenabled)
        {
            //fernseher.GetComponent<SpriteRenderer>().color = new Vector4(0, 1, 0, 1);

            flackern = true;
            player.GetComponent<PlayerMovement>().Movementenabled = false;
            if(zettel)
            {
                Debug.Log("ZETTEL ODER SO");
            }

        } else if (Input.GetKeyDown("e") && dist < radius && !player.GetComponent<PlayerMovement>().Movementenabled)
        {
            player.GetComponent<PlayerMovement>().Movementenabled = true;
        }
        if (licht.activeInHierarchy && flackern)
        {
            fernseher.GetComponent<SpriteRenderer>().color = new Vector4(0, 0, 1, 1);
        } 
    }
}
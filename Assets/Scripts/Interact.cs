using UnityEngine;

public class Interact : MonoBehaviour
{
    //Camera camera;

    public GameObject interactebal;
    public float radius = 1.5f;
    private Transform player;
    private float distancex;
    private float distancey;

    private void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    //Radius wird im Editor visualisiert

    void Update()
    {
        Vector3 differenceplayer = player.transform.position - transform.position;
        Vector3 differenceobject = interactebal.transform.position - transform.position;
        distancex = differenceplayer.x - differenceobject.x;
        distancey = differenceplayer.y - differenceobject.y;
        //Die Distanz auf der x- und y-Achse der beiden Objekte wird verglichen

        if (Input.GetKeyDown("e"))

        {
            if (distancex < radius)
            {
                if (distancey < radius)
                {
                    Debug.Log("Es wurde interagiert");
                }
            }
            //Ist die Distanz zwischen den beiden Objekten kleiner als ein festgelegter Radius, so wird ein Debug ausgeführt
        }
    }

}
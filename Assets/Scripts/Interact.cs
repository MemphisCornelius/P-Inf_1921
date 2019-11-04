using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    //Camera camera;
    public GameObject @object;
    public float radius = 1.5f;
    private Transform player;
    private float distance_x;
    private float distance_y;

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
        Vector3 difference_player = player.transform.position - transform.position;
        Vector3 difference_object = @object.transform.position - transform.position;
        distance_x = difference_player.x - difference_object.x;
        distance_y = difference_player.y - difference_object.y;
        //Die Distanz auf der x- und y-Achse der beiden Objekte wird verglichen

        if (Input.GetKey("e"))
        {
            if (distance_x < radius)
            {
                if (distance_y < radius)
                {
                    Debug.Log("Es wurde interagiert");
                }
            }
            //Ist die Distanz zwischen den beiden Objekten kleiner als ein festgelegter Radius, so wird ein Debug ausgeführt


        }
    }
}


<<<<<<< HEAD
﻿using UnityEngine;

public class Interact : MonoBehaviour
{
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    //Camera camera;
>>>>>>> cf0160d7b1fab4d262c79f1be5565eede7f24aac
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

<<<<<<< HEAD
        if (Input.GetKeyDown("e"))
=======
        if (Input.GetKey("e"))
>>>>>>> cf0160d7b1fab4d262c79f1be5565eede7f24aac
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
<<<<<<< HEAD
}
=======
}

>>>>>>> cf0160d7b1fab4d262c79f1be5565eede7f24aac

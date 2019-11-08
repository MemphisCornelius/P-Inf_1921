using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    //Camera camera;

    public GameObject interactable;
    public float radius = 1.5f;
    private Transform player;
    private float distancex;
    private float distancey;
    public bool Information;
    public GameObject information_panel;
    public GameObject information_text;

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
        Vector3 differenceobject = interactable.transform.position - transform.position;
        distancex = differenceplayer.x - differenceobject.x;
        distancey = differenceplayer.y - differenceobject.y;
        //Die Distanz auf der x- und y-Achse der beiden Objekte wird verglichen

        if (distancex > radius)
        {
            if (distancey > radius)
            {
                information_panel.SetActive(false);
                information_text.SetActive(false);
            }
        }

        if (Input.GetKeyDown("e"))

        {
            if (distancex < radius)
            {
                if (distancey < radius)
                {
                    Debug.Log("Es wurde interagiert");

                    if (Information == true)
                    {
                        information_text.SetActive(true);
                        information_panel.SetActive(true);
                    }
                }
            }
            
            //Ist die Distanz zwischen den beiden Objekten kleiner als ein festgelegter Radius, so wird ein Debug ausgeführt
        }
        
    }

}
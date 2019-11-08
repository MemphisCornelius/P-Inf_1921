using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    //Camera camera;

    public GameObject interactable;
    public float radius = 1.5f;
    private Transform player;
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
        float dist = Vector3.Distance(transform.position, player.transform.position);

        //Die Distanz auf der x- und y-Achse der beiden Objekte wird verglichen

        if (dist > radius)
        {
                information_panel.SetActive(false);
                information_text.SetActive(false);           
        }
        if (Input.GetKeyDown("e"))

        {
            if (dist < radius)
            {
                    Debug.Log("Es wurde interagiert");

                    if (Information == true)
                    {
                        information_text.SetActive(true);
                        information_panel.SetActive(true);
                    }              
            }           
            //Ist die Distanz zwischen den beiden Objekten kleiner als ein festgelegter Radius, so wird ein Debug ausgeführt
        }
        
    }

}
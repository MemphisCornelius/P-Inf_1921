using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{

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

    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.transform.position);

        if (Input.GetKeyUp("e"))
        {
                information_panel.SetActive(false);
                information_text.SetActive(false);           
        }
        if (Input.GetKeyDown("e") && dist < radius)

        {
            Debug.Log("Es wurde interagiert");

           if (Information)
           {
                 information_text.SetActive(true);
                 information_panel.SetActive(true);
           }              
                      
        }
    }
}
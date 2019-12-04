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
    bool shown = false;

    private void Start()
    {
        player = GameObject.Find("Interact").transform;
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKeyDown("e"))
        {
            if (Information)
            {
                information_text.SetActive(true);
                information_panel.SetActive(true);
            }
        }
    }
    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.transform.position);



        if (Input.GetKeyDown("e") && dist < radius)
        {
            if (shown)
            {
                shown = false;
            }
            else
            {
                shown = true;
            }
            if (Information && shown)
            {
                 information_text.SetActive(true);
                 information_panel.SetActive(true);
            }
            if (Information && !shown)
            {
                information_panel.SetActive(false);
                information_text.SetActive(false);
            }
        }
        if (dist > radius) {
            information_panel.SetActive(false);
            information_text.SetActive(false);
        }
    }
}
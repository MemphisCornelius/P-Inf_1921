using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{

    public float radius = 1.5f;
    public GameObject player;
    public bool Information, shown = false;
    public GameObject information_panel;
    public GameObject information_text;

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
                player.GetComponent<PlayerMovement>().Movementenabled = true;
            }
            else
            {
                shown = true;
                player.GetComponent<PlayerMovement>().Movementenabled = false;
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
    }
}
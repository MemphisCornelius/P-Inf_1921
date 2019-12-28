using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractPflanzeZumInteragierenDerPflanze : MonoBehaviour
{
    public float radius = 1.5f;
    public GameObject player;
    public bool Information, shown = false, first = false;
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
                information_panel.SetActive(false);
                information_text.SetActive(false);
                player.GetComponent<PlayerMovement>().Movementenabled = true;
            }
            else
            {
                if (first)
                {
                    shown = true;
                    player.GetComponent<PlayerMovement>().Movementenabled = false;
                    Debug.Log("zettel");
                    GameObject.Find("Sofa").GetComponent<FernseherRauschen>().zettel = true;
                    information_text.SetActive(true);
                    information_panel.SetActive(true);
                } else
                {
                    first = true;
                }
            }
        }
    }
}
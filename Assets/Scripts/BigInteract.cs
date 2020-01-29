using UnityEngine;
using UnityEngine.Events;

public class BigInteract : MonoBehaviour
{
    public GameObject information_panel;
    public bool shown;
    public GameObject information_text;
    public Transform player;
    public bool first;
    [System.Serializable] public class _UnityEventFloat : UnityEvent<GameObject> { }
    public void InteractPflanzeToInteractThePflanze()
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
            }
            else
            {
                first = true;
            }
        }
    }
    public void interact_stranger()
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
                information_text.SetActive(true);
                information_panel.SetActive(true);
            }
            else
            {
                first = true;
            }
        }
    }
}
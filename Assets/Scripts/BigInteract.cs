using UnityEngine;
using UnityEngine.Events;

public class BigInteract : MonoBehaviour
{
    [System.Serializable] public class _UnityEventFloat : UnityEvent<GameObject> { }
    public void InteractPflanzeToInteractThePflanze(bool shown, GameObject information_panel, GameObject information_text, GameObject player, bool first)
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
}
using UnityEngine;
using UnityEngine.Events;

public class InteractionsScene1 : MonoBehaviour
{
    public GameObject Animation_Stranger;
    public GameObject information_panel;
    public bool shown;
    public GameObject information_text;
    public GameObject information_textzettel;
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
            Animation_Stranger.GetComponent<Animator>().SetBool("StartAnimation", false);
            shown = false;
            information_panel.SetActive(false);
            information_text.SetActive(false);
            player.GetComponent<PlayerMovement>().Movementenabled = true;
        }
        else
        {
            if (first)
            {
                Animation_Stranger.GetComponent<Animator>().SetBool("StartAnimation", true);
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
    public void interact_zettel()
    {
        
        if (shown)
        {
            
            shown = false;
            information_panel.SetActive(false);
            information_textzettel.SetActive(false);
            player.GetComponent<PlayerMovement>().Movementenabled = true;
        }
        else
        {
            
            if (first)
            {
                
                shown = true;
                player.GetComponent<PlayerMovement>().Movementenabled = false;
                information_textzettel.SetActive(true);
                information_panel.SetActive(true);
            }
            else
            {
                first = true;
            }
        }
    }
}
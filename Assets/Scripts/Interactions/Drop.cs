using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Drag drag = eventData.pointerDrag.GetComponent<Drag>();
        if (drag != null)
        {
            drag.ToParent = this.transform;
            if (eventData.pointerDrag.tag == this.tag)
            {
                if (this.tag == "Zone" + drag.CableNumber)
                {
                    PlayerPrefs.SetInt("Cable" + drag.CableNumber, 1);
                    Debug.Log(PlayerPrefs.GetInt("Cable" + drag.CableNumber));
                }
            }
            if (eventData.pointerDrag.tag != this.tag)
            {
                PlayerPrefs.SetInt("Cable" + drag.CableNumber, 0);
                Debug.Log(PlayerPrefs.GetInt("Cable" + drag.CableNumber));
            }
        }
    }
}

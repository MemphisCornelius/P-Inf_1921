using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactions_Level_4 : MonoBehaviour
{
    public GameObject[] UI_Objects;


    public void ClosePanel()
    {
        foreach (GameObject UI_Object in UI_Objects)
        {
            UI_Object.SetActive(false);
        }
    }

    [System.Serializable] public class _UnityEventFloat : UnityEvent<GameObject> { }

    public void SofaInteract()
    {
        UI_Objects[0].SetActive(true);
        UI_Objects[1].SetActive(true);
    }
    
    public void BrokenFloorInteract()
    {
        UI_Objects[0].SetActive(true);
        UI_Objects[2].SetActive(true);
    }

    public void ChandelierInteract()
    {
        UI_Objects[0].SetActive(true);
        UI_Objects[3].SetActive(true);
    }

    public void WinchInteract()
    {
        UI_Objects[0].SetActive(true);
        UI_Objects[4].SetActive(true);
    }

    public void BoxInteract()
    {
        UI_Objects[0].SetActive(true);
        UI_Objects[5].SetActive(true);
    }

}

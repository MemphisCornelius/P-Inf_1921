using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interations_Level_5 : MonoBehaviour
{
    public GameObject Door;
    public GameObject[] UI_Objects1;
    public GameObject[] UI_Objects2;
    public bool Riddle1 = false;
    public bool Riddle2 = false;

    public void DoorInteract()
    {
        if (Riddle2)
        {
            Door.SetActive(false);
        }
    }

    public void Riddle_1_Active()
    {
        foreach (GameObject UI_Object1 in UI_Objects1)
        {
            UI_Object1.SetActive(true);
        }
    }

}

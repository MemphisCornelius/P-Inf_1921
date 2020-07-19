using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interations_Level_5 : MonoBehaviour
{
    public GameObject Door;
    public GameObject Panel;
    public GameObject[] UI_Objects1;
    public GameObject[] UI_Objects2;
    public bool Riddle1 = false;
    public bool Riddle2 = false;
    public bool[] ButtonCount;

    public void Start()
    {
        foreach (GameObject UI_Object1 in UI_Objects1)
        {
            UI_Object1.transform.Rotate(0, 0, 0);
        }
    }

    public void DoorInteract()
    {
        if (Riddle2)
        {
            Door.SetActive(false);
        }
    }
    public void Riddle_1_Active()
    {
        Panel.SetActive(true);
        foreach (GameObject UI_Object1 in UI_Objects1)
        {
            UI_Object1.SetActive(true);
        }
    }
    public void Riddle_1_1()
    {
        UI_Objects1[0].transform.Rotate(0, 0, 90);
        Debug.Log(UI_Objects1[0].transform.rotation.eulerAngles.z);
        if (Mathf.Round(UI_Objects1[0].transform.rotation.eulerAngles.z) == 180)
        {
            ButtonCount[0] = true;
        }
        else
        {
            ButtonCount[0] = false;
        }
    }
    public void Riddle_1_2()
    {
        UI_Objects1[1].transform.Rotate(0, 0, 90);
        if (Mathf.Round(UI_Objects1[1].transform.rotation.eulerAngles.z) == 90)
        {
            ButtonCount[1] = true;
        }
        else
        {
            ButtonCount[1] = false;
        }
    }
    public void Riddle_1_3()
    {
        UI_Objects1[2].transform.Rotate(0, 0, 90);
        if (Mathf.Round(UI_Objects1[2].transform.rotation.eulerAngles.z) == 90 || Mathf.Round(UI_Objects1[2].transform.rotation.eulerAngles.z) == 270)
        {
            ButtonCount[2] = true;
        }
        else
        {
            ButtonCount[2] = false;
        }
    }
    public void Riddle_1_4()
    {
        UI_Objects1[3].transform.Rotate(0, 0, 90);
        if (Mathf.Round(UI_Objects1[3].transform.rotation.eulerAngles.z) == 270)
        {
            ButtonCount[3] = true;
        }
        else
        {
            ButtonCount[3] = false;
        }
    }
    public void Riddle_1_5()
    {
        UI_Objects1[4].transform.Rotate(0, 0, 90);
        if (Mathf.Round(UI_Objects1[4].transform.rotation.eulerAngles.z) == 180)
        {
            ButtonCount[4] = true;
        }
        else
        {
            ButtonCount[4] = false;
        }
    }
    public void EndRiddle_1()
    {
        if (ButtonCount[0] == true && ButtonCount[1] == true && ButtonCount[2] == true && ButtonCount[3] == true && ButtonCount[4] == true)
        {
            Debug.Log("Riddle1End");
            Riddle1 = true;
        }
        }
    public void ClosePanel()
    {
        foreach (GameObject UI_Object1 in UI_Objects1)
        {
            UI_Object1.SetActive(false);
        }
        foreach (GameObject UI_Object2 in UI_Objects2)
        {
            UI_Object2.SetActive(false);
        }
        Panel.SetActive(false);
    }
}

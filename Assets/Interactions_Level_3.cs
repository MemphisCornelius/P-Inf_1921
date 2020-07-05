using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Interactions_Level_3 : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Information_Image;
    public bool StartRiddle = false;

    public void ClosePanel()
    {
        Panel.SetActive(false);
        Information_Image.SetActive(false);
    }

    [System.Serializable] public class _UnityEventFloat : UnityEvent<GameObject> { }

    public void DeskRiddle()
    {
        Panel.SetActive(true);
        Information_Image.SetActive(true);
        StartRiddle = true;
    }

    public void Robot_1_Interact()
    {
        if (StartRiddle)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void OpenDoor()
    {
        
    }
}

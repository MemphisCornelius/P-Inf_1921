using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactions_Level_4 : MonoBehaviour
{
    public GameObject[] UI_Objects;
    public Rigidbody2D Player;
    public Rigidbody2D Sofa;
    public GameObject sofa;
    public bool SofaPickUp = false;
    public bool OilUSed = false;

    public void ClosePanel()
    {
        foreach (GameObject UI_Object in UI_Objects)
        {
            UI_Object.SetActive(false);
        }
    }

    public void SofaButton()
    {
        ClosePanel();
        sofa.SetActive(false);
        SofaPickUp = true;
    }

    [System.Serializable] public class _UnityEventFloat : UnityEvent<GameObject> { }

    public void SofaInteract()
    {
        if (!(Player.position.y <= 0.6 && Player.position.y >= -0.6 && Player.position.x <= 2.6 && Player.position.x >= -0.6))
        {
            UI_Objects[0].SetActive(true);
            UI_Objects[1].SetActive(true);
            UI_Objects[6].SetActive(true);
        }
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
        if (!SofaPickUp && !OilUSed)
        {
            UI_Objects[0].SetActive(true);
            UI_Objects[4].SetActive(true);

            if ((Player.position.y <= 0.6 && Player.position.y >= -0.6 && Player.position.x <= 2.6 &&
                  Player.position.x >= -0.6) && PlayerPrefs.GetInt("oliveoil") == 1)
            {
                UI_Objects[7].SetActive(true);
            }
        }
    }

    public void UseOliveOil() {
        PlayerPrefs.SetInt("oliveoil", 0);
        OilUSed = true;
        ClosePanel();
    }

    public void BoxInteract()
    {
        UI_Objects[0].SetActive(true);
        UI_Objects[5].SetActive(true);
    }

    public void Update()
    {
        if (SofaPickUp && Input.GetKeyDown("e") && Player.position.x <= 5 && Player.position.x >= -5 && Player.position.y <= 2.5 && Player.position.y >= -3)
        {
            sofa.SetActive(true);
            Sofa.position = Player.position;
            Vector3 placevector = Sofa.position;
            if (Player.position.y > 2)
            {
                placevector.y = placevector.y - 1;
            }
            else
            {
                placevector.y = placevector.y + 1;
            }
            Player.position = placevector;
            SofaPickUp = false;
        }
    }
}

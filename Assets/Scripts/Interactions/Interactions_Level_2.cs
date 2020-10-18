using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Interactions_Level_2 : MonoBehaviour
{
    public GameObject Panel;
    public bool Start_Riddle = false;
    public GameObject Text_Bookshelf;
    public GameObject Kitchen_Key_Image;
    public bool Kitchen_Key_Active = false;
    public GameObject Kitchen_Door;
    public bool Kitchen_Note_Active = false;
    public GameObject Kitchen_Note_Text;
    public GameObject Stairway_Key_Image;
    public bool Stairway_Key_Active = false;
    public GameObject Oliveoil_Text;
    public GameObject Oliveoil_Button;
    public GameObject Trap_Door_Text;
    public GameObject OliveOil;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Panel.SetActive(false);
            Text_Bookshelf.SetActive(false);
            Kitchen_Key_Image.SetActive(false);
            Stairway_Key_Image.SetActive(false);
            Kitchen_Note_Text.SetActive(false);
            Oliveoil_Text.SetActive(false);
            Trap_Door_Text.SetActive(false);
            Oliveoil_Button.SetActive(false);
        }
    }

    public void ClosePanel()
    {
        Panel.SetActive(false);
        Text_Bookshelf.SetActive(false);
        Kitchen_Key_Image.SetActive(false);
        Stairway_Key_Image.SetActive(false);
        Kitchen_Note_Text.SetActive(false);
        Oliveoil_Text.SetActive(false);
        Trap_Door_Text.SetActive(false);
        Oliveoil_Button.SetActive(false);
    }
    [System.Serializable] public class _UnityEventFloat : UnityEvent<GameObject> { }

    public void Riddle_Bookshelf()
    {
            if (Kitchen_Note_Active)
            {
                Panel.SetActive(true);
                Stairway_Key_Image.SetActive(true);
                Stairway_Key_Active = true;
            }
            else
            {
                Panel.SetActive(true);
                Text_Bookshelf.SetActive(true);
                Start_Riddle = true;
            }
    }

    public void Carpet_Interact()
    {
        if (Start_Riddle)
        {
            Panel.SetActive(true);
            Kitchen_Key_Image.SetActive(true);
            Kitchen_Key_Active = true;
        }
    }

    public void Open_Kitchen()
    {
        if (Kitchen_Key_Active)
        {
            Kitchen_Door.SetActive(false);
        }
    }

    public void Riddle_Kitchen()
    {
        Panel.SetActive(true);
        Kitchen_Note_Text.SetActive(true);
        Kitchen_Note_Active = true;
    }

    public void Oliveoil_Interact()
    {
        Panel.SetActive(true);
        Oliveoil_Text.SetActive(true);
        Oliveoil_Button.SetActive(true);
    }

    public void OliveoilButton() {
        PlayerPrefs.SetInt("oliveoil", 1);
        OliveOil.SetActive(false);
        ClosePanel();
    }

    public void Trap_Door_Interact()
    {
        Panel.SetActive(true);
        Trap_Door_Text.SetActive(true);
    }

    public void Level2_Transition()
    {
        if (Stairway_Key_Active)
        {
            SceneManager.LoadScene(2);
        }
    }
}
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
    public bool AxeEquip = false;
    public GameObject AxeImage;
    public GameObject Crate;
    public bool CarryRobot = false;
    public GameObject Robot_3_Text;
    public GameObject Robot_3;
    public int Brickcount;
    public GameObject BrickWall;
    public GameObject[] Riddle_Text;
    public GameObject BrickWallImage;
    public GameObject BrokenFloorText;
    public GameObject CloseButton;
    public GameObject EndRiddle;
    public bool CrateDestroy = false;
    public bool EndLevel = false;

    public void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("MinigameWon"));
    }

    public void ClosePanel()
    {
        Panel.SetActive(false);
        Information_Image.SetActive(false);
        Robot_3_Text.SetActive(false);
        AxeImage.SetActive(false);
        Riddle_Text[0].SetActive(false);
        Riddle_Text[1].SetActive(false);
        Riddle_Text[2].SetActive(false);
        BrickWallImage.SetActive(false);
        CloseButton.SetActive(false);
        BrokenFloorText.SetActive(false);
        EndRiddle.SetActive(false);
    }

    public void PressBrick()
    {
        Brickcount = Brickcount + 1;
        if (Brickcount == 3)
        {
            BrickWall.SetActive(false);
            BrickWallImage.SetActive(false);
            CloseButton.SetActive(false);
        }
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
        if (StartRiddle && PlayerPrefs.GetInt("Minigame1Won") != 1)
        {
            SceneManager.LoadScene(3);
        }
        if (PlayerPrefs.GetInt("Minigame1Won") == 1)
        {
            Panel.SetActive(true);
            Riddle_Text[0].SetActive(true);
        }
    }

    public void Crate_Interact()
    {
        if (AxeEquip)
        {
            Crate.SetActive(false);
            CrateDestroy = true;
        }
    }

    public void Robot_2_Interact()
    {
        if (CrateDestroy)
        {
            if (PlayerPrefs.GetInt("Minigame2Won") != 2)
            {
                SceneManager.LoadScene(4);
            }
            if (PlayerPrefs.GetInt("Minigame2Won") == 2)
            {
                Panel.SetActive(true);
                Riddle_Text[1].SetActive(true);
            }
        }
    }

    public void Robot_3_Interact()
    {
        if (PlayerPrefs.GetInt("Minigame3Won") != 3)
        {
            SceneManager.LoadScene(5);
        }
        if (PlayerPrefs.GetInt("Minigame3Won") == 3)
        {
            Panel.SetActive(true);
            Riddle_Text[2].SetActive(true);
        }
    }

    public void PickupAxe()
    {
        if (StartRiddle)
        {
            Panel.SetActive(true);
            AxeImage.SetActive(true);
            AxeEquip = true;
        }
    }

    public void SinkInteract()
    {
        if (StartRiddle)
        {
            Panel.SetActive(true);
            Robot_3_Text.SetActive(true);
            CarryRobot = true;
        }
    }

    public void HeaterInteract()
    {
        if (CarryRobot)
        {
            Robot_3.SetActive(true);
        }
    }

    public void BrickWallInteract()
    {
        BrickWallImage.SetActive(true);
        CloseButton.SetActive(true);
    }

    public void BrokenFloorInteract()
    {
        Panel.SetActive(true);
        BrokenFloorText.SetActive(true);
    }

    public void NoteInteract()
    {
        Panel.SetActive(true);
        EndRiddle.SetActive(true);
        EndLevel = true;
    }

    public void LevelTransition()
    {
        if (EndLevel)
        {
            SceneManager.LoadScene(13);
        }
    }

    public void ResetPlayerPrefs()
    {
        for(int i = 1; i <= 3; i++)
        {
            PlayerPrefs.SetInt("Minigame" + i + "Won", 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuFunctions : MonoBehaviour
{
    Canvas main, optionen, spielstaende, spielAnpassungen;
    public void Awake()
    {
        main = GameObject.Find("Hauptmenue").GetComponent<Canvas>();
        optionen = GameObject.Find("Optionen").GetComponent<Canvas>();
        spielstaende = GameObject.Find("Spielstaende").GetComponent<Canvas>();
        spielAnpassungen = GameObject.Find("Spielanpassungen").GetComponent<Canvas>();
    }
    public void Start()
    {
        main.enabled = true;
        optionen.enabled = false;
        spielstaende.enabled = false;
        spielAnpassungen.enabled = false;
    }
    public void SpielstandLaden(int spielstand)
    {
        Debug.Log(spielstand);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hotbar : MonoBehaviour
{
    public Sprite Schlüssel, Buch;
    public Image[] item;
    string[] hotbar = new string[10];
    int hotbarcount = 0;
    int anzahl, rich;

    void Start()
    {
        for (int i = 0; i < item.Length; i++)
        {
            item[i].transform.position = new Vector2(900, 100);
        }
    }

    void Update()
    {
        if (Input.mousePosition.x > 900 && Input.mousePosition.y < 100 && rich == 0)
        {
            anzahl = 0;
            rich = 1;
        }
        if (rich !=0)move();
    }

    public void Hotbar_Dazu(string name)
    {
        hotbar[hotbarcount] = name;
        hotbarcount++;
        updaten();
    }
    public void Hotbar_Weg(string name)
    {
        for (int i = 0; i < hotbar.Length; i++)
        {
            if (hotbar[i] == name) hotbar[i] = null;
            hotbarcount--;
        }
        for (int i = 1; i < hotbar.Length; i++)
        {
            if (hotbar[i - 1] == null)
            {
                hotbar[i - 1] = hotbar[i];
                hotbar[i] = null;
            }
        }
        updaten();
    }
    Sprite Convert(string name)
    {
        switch (name)
        {
            case "Schlüssel": return Schlüssel;
            case "Buch": return Buch;
            default:Debug.Log("Hotbar: kein Bild!");
                    return null;
        }
    }
    void updaten()
    {
        for (int i = 0; i < hotbar.Length; i++)
        {
            if (hotbar[i] == null) item[i].enabled = false;
            else
            {
                item[i].enabled = true;
                item[i].sprite = Convert(hotbar[i]);
            }
        }
    }

    void move()
    {
        for (int i = anzahl/20; i < item.Length; i++)
        {
            item[i].transform.position += Vector3.left*2;  
        }
        anzahl++;

        if(anzahl==200)rich=0;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Activation : MonoBehaviour
{
    public GameObject EndGame_Panel;
    public GameObject Defeat_Text;
    public GameObject Victory_Text;

    public void Update()
    {
        int Enemycount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        int Playercount = GameObject.FindGameObjectsWithTag("Player").Length;

        if (Enemycount <= 0 || Playercount <= 0)
        {
            EndGame_Panel.SetActive(true);
            if (Enemycount <= 0)
            {
                Victory_Text.SetActive(true);
            }
            else
            {
                Defeat_Text.SetActive(true);
            }

        }
    }
}

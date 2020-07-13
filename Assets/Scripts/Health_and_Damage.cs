using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_and_Damage : MonoBehaviour
{
    public int Health = 100;

    public void Damage(int damage)
    {
        Health = Health - damage;
        if (Health <= 0)
        {
            gameObject.SetActive(false);
        }
    }


}

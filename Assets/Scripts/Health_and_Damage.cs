using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_and_Damage : MonoBehaviour
{
    public int Enemy_health = 100;

    public void Damage(int damage)
    {
        Enemy_health = Enemy_health - damage;
        if (Enemy_health <= 0)
        {
            Destroy(gameObject);
        }
    }


}

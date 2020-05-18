using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_and_Damage : MonoBehaviour
{
    public int Enemy_health = 100;
    public int Player_health = 50;
    public bool EnemyShot;
    public void Damage(int damage)
    {
        if (EnemyShot == true)
        {
            Enemy_health = Player_health;
        }
        Enemy_health = Enemy_health - damage;
        if (Enemy_health <= 0)
        {
            Destroy(gameObject);
        }
    }


}

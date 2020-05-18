using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public int dealt_damage = 25;
    public void OnTriggerEnter2D(Collider2D Enemy_Object)
    {
        Health_and_Damage HaD = Enemy_Object.GetComponent<Health_and_Damage>();
        if (HaD != null)
        {
            HaD.Damage(dealt_damage);
        }
        /*
        GameObject projectile = GetComponent<Shooting>().projectile;     
        if (projectile != Enemy_Object)
        {
            Destroy(gameObject);
            Debug.Log(Enemy_Object.name);
        }*/
        Destroy(gameObject);
        Debug.Log(Enemy_Object.name);
    }
}   

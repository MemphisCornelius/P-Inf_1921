using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public int dealt_damage = 25;
    public GameObject EnemyPrefab;
    public bool PlayerShot;
   
    public void OnTriggerEnter2D(Collider2D Enemy_Object)
    {
        Health_and_Damage HaD = Enemy_Object.GetComponent<Health_and_Damage>();

        if (HaD != null && Enemy_Object.tag != EnemyPrefab.tag)
        {
            HaD.Damage(dealt_damage);
        }

        if (HaD != null && PlayerShot)
        {
            HaD.Damage(dealt_damage);
        }

        if (Enemy_Object.tag != "Projectile")
        {
            //EnemyPrefab.GetComponent<Animator>().SetBool("Explosion", true);
            Destroy(gameObject); 
            //animation explosion
            Debug.Log(Enemy_Object.name);
        }
    }
}   

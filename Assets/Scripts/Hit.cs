using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public int dealt_damage = 25;

    public void OnTriggerEnter2D(Collider2D Enemy_Object)
    {
        Enemy en = Enemy_Object.GetComponent<Enemy>();
        if (en != null)
        {
            en.Damage(dealt_damage);
        }
        Destroy(gameObject);
        Debug.Log(Enemy_Object.name);
    }
}   

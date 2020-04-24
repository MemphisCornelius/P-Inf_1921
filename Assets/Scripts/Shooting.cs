using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform Fire_Point;
    public GameObject projectilePrefab;

    public float projectile_Force = 20f;

    public void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, Fire_Point.position, Fire_Point.rotation);
        Rigidbody2D rd = projectile.GetComponent<Rigidbody2D>();
        rd.AddForce(Fire_Point.up * projectile_Force, ForceMode2D.Impulse);

    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
}

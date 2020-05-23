using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform Fire_Point;
    public GameObject projectilePrefab;
    public bool EnemyShot;
    public GameObject projectile;
    public float ShotIntervall = 0.4f;
    public Transform Fire_Point2;
    public bool multipleShoots;

    public float projectile_Force = 20f;

    public void Shoot()
    {
        projectile = Instantiate(projectilePrefab, Fire_Point.position, Fire_Point.rotation);
        Rigidbody2D rd = projectile.GetComponent<Rigidbody2D>();
        rd.AddForce(Fire_Point.up * projectile_Force, ForceMode2D.Impulse);

        if (multipleShoots == true)
        {
            GameObject projectile2 = Instantiate(projectilePrefab, Fire_Point2.position, Fire_Point2.rotation);
            Rigidbody2D rd2 = projectile2.GetComponent<Rigidbody2D>();
            rd2.AddForce(Fire_Point2.up * projectile_Force, ForceMode2D.Impulse);
        }
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1") && EnemyShot == false)
        {
            Shoot();
        }

        if (EnemyShot == true)
        {
            ShotIntervall = ShotIntervall - Time.deltaTime;
            if (ShotIntervall <= 0)
            {
                Shoot();
                ShotIntervall = 0.4f;
            }
        }
    }
}

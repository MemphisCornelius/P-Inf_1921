using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform Fire_Point;
    public GameObject projectilePrefab;
    public bool EnemyShot;
    public GameObject projectile;
    public float ShotCountdown = 0.4f;
    public Transform Fire_Point2;
    public Transform Fire_Point3;
    public Transform Fire_Point4;
    public bool multipleShoots;
    public float projectile_Force = 20f;
    public float ShotReset = 0.4f;
    public bool MoreMultipleShots;

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

            if (MoreMultipleShots == true)
            {
                GameObject projectile3 = Instantiate(projectilePrefab, Fire_Point3.position, Fire_Point3.rotation);
                Rigidbody2D rd3 = projectile3.GetComponent<Rigidbody2D>();
                rd3.AddForce(Fire_Point3.up * projectile_Force, ForceMode2D.Impulse);

                GameObject projectile4 = Instantiate(projectilePrefab, Fire_Point4.position, Fire_Point4.rotation);
                Rigidbody2D rd4 = projectile4.GetComponent<Rigidbody2D>();
                rd4.AddForce(Fire_Point4.up * projectile_Force, ForceMode2D.Impulse);
            }
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
            ShotCountdown = ShotCountdown - Time.deltaTime;
            if (ShotCountdown <= 0)
            {
                Shoot();
                ShotCountdown = ShotReset;
            }
        }
    }
}

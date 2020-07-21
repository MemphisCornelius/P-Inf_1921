using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public bool EnemyShot;
    public float ShotCountdown = 0.4f;
    public float projectile_Force = 20f;
    public float ShotReset = 0.4f;
    public Transform[] firePoints;

    public void Shoot()
    {
        foreach (Transform firePoint in firePoints) {
            GameObject pro = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rigid = pro.GetComponent<Rigidbody2D>();
            rigid.AddForce(firePoint.up * projectile_Force, ForceMode2D.Impulse);
        }
    }

    void Update()
    {

        if(Input.GetButtonDown("Fire1") && !EnemyShot)
        {
            Shoot();
        }

        if (EnemyShot)
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

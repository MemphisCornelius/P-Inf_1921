using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    private Vector3 mouse;
    public Transform enemy;

    void Update ()
    {
        mouse = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));

        if (Input.GetKeyDown("mouse 0"))
        {
            //play Animation

            Vector3 differenceEnemy = enemy.transform.position - transform.position;
            float radiantenemy = Mathf.Atan2(differenceEnemy.y, differenceEnemy.x) * Mathf.Rad2Deg;
            Vector3 differenceMouse = mouse - transform.position;
            float radiantmouse = Mathf.Atan2(differenceMouse.y, differenceMouse.x) * Mathf.Rad2Deg;

            if (Mathf.Abs(radiantenemy - radiantmouse) < 90 || (Mathf.Abs(radiantenemy - radiantmouse) > 270 && Mathf.Abs(radiantenemy - radiantmouse) < 360))
            {
                Debug.Log(radiantmouse - radiantenemy);
            }
        }
    }   
}
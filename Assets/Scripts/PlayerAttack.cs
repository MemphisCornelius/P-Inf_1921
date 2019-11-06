using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Vector3 mouse;
    public GameObject enemy;
    public float push;

    void Update ()
    {
        mouse = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        float dist = Vector3.Distance(transform.position, enemy.transform.position);

        if (Input.GetKeyDown("mouse 0"))
        {
            //play Animation
            if (dist <= 3) {
                Vector3 differenceEnemy = enemy.transform.position - transform.position;
                float radiantenemy = Mathf.Atan2(differenceEnemy.y, differenceEnemy.x) * Mathf.Rad2Deg;
                Vector3 differenceMouse = mouse - transform.position;
                float radiantmouse = Mathf.Atan2(differenceMouse.y, differenceMouse.x) * Mathf.Rad2Deg;

                if (Mathf.Abs(radiantenemy - radiantmouse) < 90 || (Mathf.Abs(radiantenemy - radiantmouse) > 270 && Mathf.Abs(radiantenemy - radiantmouse) < 360))
                {
                    enemy.GetComponent<Enemy>().hp = enemy.GetComponent<Enemy>().hp - 5 - ( 10 - dist * 3);

                    enemy.GetComponent<Rigidbody2D>().AddForce(new Vector2((-1 / (transform.position.x * push - enemy.transform.position.x * push)), (1 / -(transform.position.y * push - enemy.transform.position.y * push))));
                    /*Debug.Log("dis" + + (transform.position.x - enemy.transform.position.x) + ", " + (transform.position.y - enemy.transform.position.y));
                    Debug.Log((-(push / (transform.position.x - enemy.transform.position.x))) + ", " + (-(push / (transform.position.y - enemy.transform.position.y))));
                    enemy.GetComponent<Rigidbody2D>().AddForce(new Vector2(
                        (-(push / (transform.position.x - enemy.transform.position.x))),
                        (-(push / (transform.position.y - enemy.transform.position.y)))
                        ));*/
                }
            }
        }
    }
}
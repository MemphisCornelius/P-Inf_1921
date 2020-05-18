using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D Player;
    public Rigidbody2D rb;

    public void Update()
    {
        Vector2 Direction = Player.position - rb.position;

        float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg - 270f;

        rb.rotation = angle;
    }
}

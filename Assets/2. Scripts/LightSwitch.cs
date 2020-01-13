using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject licht, player;
    public float radius;
    float dist;
    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.transform.position);
        if (Input.GetKeyDown("e") && dist < radius && !licht.activeInHierarchy)
        {
            licht.SetActive(true);

        } else if (Input.GetKeyDown("e") && dist < radius && licht.activeInHierarchy)
        {
            licht.SetActive(false);
        }
    }
}

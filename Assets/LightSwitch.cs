using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject light, player;
    public float radius;
    float dist;
    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.transform.position);
        if (Input.GetKeyDown("e") && dist < radius && !light.activeInHierarchy)
        {
            light.SetActive(true);

        } else if (Input.GetKeyDown("e") && dist < radius && light.activeInHierarchy)
        {
            light.SetActive(false);
        }
    }
}

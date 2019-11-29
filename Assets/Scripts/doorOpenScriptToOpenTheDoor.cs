﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorOpenScriptToOpenTheDoor : MonoBehaviour
{
    public bool key;
    public Canvas can;
    public GameObject door, doorOpener;
    public float maxdis;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        key = can.GetComponent<numpad>().geil;
        float dis = Vector3.Distance(transform.position, door.transform.position);
        if (dis <= maxdis && Input.GetKeyDown("l") && key)
        {
            doorOpener.transform.rotation = Quaternion.Euler(0,0,-90f);
            SceneManager.LoadScene(2);
        }
    }
}
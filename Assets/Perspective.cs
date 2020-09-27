using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perspective : MonoBehaviour {
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject g;

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log(other);
    }
}

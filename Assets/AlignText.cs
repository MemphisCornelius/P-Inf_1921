using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlignText : MonoBehaviour
{
    public GameObject enemyObject;
    public bool respawnEnemy = false;

    void Update()
    {
        Vector3 textPos = Camera.main.WorldToScreenPoint(enemyObject.transform.position);
        Vector3 replaceVec = new Vector3(900, 900, 900);
        if (!respawnEnemy)
        {
            transform.position = textPos;
        }
        else
        {
            transform.position = replaceVec;
        }
        if (enemyObject.activeSelf)
        {
            respawnEnemy = false;
        }
        if (!enemyObject.activeSelf && !respawnEnemy)
        {
            gameObject.SetActive(false);
        }
    }
}
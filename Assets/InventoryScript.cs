using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public string[][] items = new string[10][];
    //itemarray = name, descripton
    public GameObject prefab, parent;

    int zaehler = 0;

    public void createSlot(GameObject prefab, string[] item)
    {
        items[zaehler] = item;
        zaehler++;
        
        Instantiate(prefab, Vector3.zero, Quaternion.identity, parent.transform);
    }
}
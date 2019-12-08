using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Script : MonoBehaviour
{
    public GameObject Inventory;

    public void open()
    {
        Inventory.SetActive(true);
    }

    public void close()
    {
        Inventory.SetActive(false);
    }
}

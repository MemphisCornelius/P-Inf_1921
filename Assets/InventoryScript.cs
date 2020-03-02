using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    List<Items> inventory = new List<Items>();
    List<GameObject> spawned = new List<GameObject>();
    public int counter;
    Vector3 offset, spawn;
    public GameObject canvas, cachette;  
    void Start()
    {       
    }
    public void AddItem(string newName, string newDescription, int newPower, GameObject newPicture)
    {
        for (int i = 0; i < spawned.Count; i++)
        {
            Destroy(spawned[i]);
        }
        spawned.Clear();
        inventory.Add(new Items(newName, newDescription, newPower, newPicture));
        for (int i = 0; i < inventory.Count ; i++)
        {
            offset = new Vector3(-40 * i+1, 0);
            cachette = inventory[i].picture;
            GameObject g = Instantiate(cachette, spawn + offset, Quaternion.identity, canvas.transform);
            spawned.Add(g);
        }
    }
    public void RemoveItem(string TÖTEETWASDEINERWAHLZUMTÖTENDEINERWAHL)
    {
        for (int i = 0; i < spawned.Count; i++)
        {
            Destroy(spawned[i]);
        }
        spawned.Clear();
        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i]._name == TÖTEETWASDEINERWAHLZUMTÖTENDEINERWAHL)
            {
                inventory.Remove(inventory[i]);
                break;
            }
        }
        for (int i = 0; i < inventory.Count; i++)
        {
            offset = new Vector3(-40 * i + 1, 0);
            GameObject g = Instantiate(cachette, spawn + offset, Quaternion.identity, canvas.transform);
            spawned.Add(g);
        }
    }
}

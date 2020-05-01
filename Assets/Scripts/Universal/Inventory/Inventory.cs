using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    List<Item> inventory = new List<Item>();
    List<GameObject> spawned = new List<GameObject>();
    public int counter;
    [SerializeField]public Vector3 offset, spawn;
        
    [HideInInspector ]public GameObject cachette;
    
    public void AddItem(string newName, string newDescription, int newPower, GameObject newPicture)
    {
        AddItem(new Item(newName, newDescription, newPower, newPicture));
        
    }

    public void AddItem(Item item) {
        
        for (int i = 0; i < spawned.Count; i++)
        {
            Destroy(spawned[i]);
        }
        
        spawned.Clear();
        inventory.Add(item);
        for (int i = 0; i < inventory.Count ; i++)
        {
            offset = new Vector3(-offset.x * i+1, offset.y);
            cachette = inventory[i].picture;
            GameObject g = Instantiate(cachette, spawn + offset, Quaternion.identity, transform);
            spawned.Add(g);
        }
    }

    public bool ContainsItem(Item item) {
        return inventory.Contains(item);
    }
    
    public void RemoveItem(string removeItemName)
    {
        for (int i = 0; i < spawned.Count; i++)
        {
            Destroy(spawned[i]);
        }
        spawned.Clear();
        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i]._name.Equals(removeItemName))
            {
                inventory.Remove(inventory[i]);
                break;
            }
        }
        for (int i = 0; i < inventory.Count; i++)
        {
            offset = new Vector3(-offset.x * i+1, offset.y);
            GameObject g = Instantiate(cachette, spawn + offset, Quaternion.identity, transform);
            spawned.Add(g);
        }
    }
}

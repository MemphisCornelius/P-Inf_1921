using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Item : IComparable<Item>
{
    public string _name;
    public string description;
    public int power;
    public GameObject picture;

    public Item(string newName, string newDescription, int newPower, GameObject newPicture)
    {
        _name = newName;
        description = newDescription;
        power = newPower;
        picture = newPicture;
    }


    public int CompareTo(Item other)
    {
        if (other == null)
        {
            return 1;
        }
        return power - other.power;
    }
}
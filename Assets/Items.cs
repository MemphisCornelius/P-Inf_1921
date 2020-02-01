using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Items : IComparable<Items>
{
    public string _name;
    public string description;
    public int power;
    public GameObject picture;

    public Items(string newName, string newDescription, int newPower, GameObject newPicture)
    {
        _name = newName;
        description = newDescription;
        power = newPower;
        picture = newPicture;
    }


    public int CompareTo(Items other)
    {
        if (other == null)
        {
            return 1;
        }
        return power - other.power;
    }
}
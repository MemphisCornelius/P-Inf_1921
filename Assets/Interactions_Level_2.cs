using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactions_Level_2 : MonoBehaviour
{
    public GameObject Panel;
    public bool Start_Riddle = false;
    public Rigidbody2D Player;
    public Vector2 distance;
    public Rigidbody2D InteractObject;
    public float Radius;

    public void ClosePanel()
    {
        Panel.SetActive(false);
    }


    [System.Serializable] public class _UnityEventFloat : UnityEvent<GameObject> { }

    public void Initiate_Riddle_Bookshelf()
    {
        distance = Player.position - InteractObject.position;
        Radius = InteractObject.GetComponent<Interact>().radius;
        if (distance.x < Radius && distance.y < Radius)
        {
            Panel.SetActive(true);
            Start_Riddle = true;
        }
    }

    public void Carpet_Interact()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

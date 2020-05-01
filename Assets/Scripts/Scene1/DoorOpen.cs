using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpen : MonoBehaviour
{
    public bool key;
    public Canvas can;
    public GameObject door, doorOpener;
    public float maxdis;
    [SerializeField] private Inventory inv;

    // Update is called once per frame
    void Update()
    {
        key = can.GetComponent<numpad>().geil;
        float dis = Vector3.Distance(transform.position, door.transform.position);
        if (dis <= maxdis && Input.GetKeyDown("e") && key)
        {
            doorOpener.transform.rotation = Quaternion.Euler(0,0,-90f);
            inv.RemoveItem("Schluessel");
            SceneManager.LoadScene(1);
        }
    }

}

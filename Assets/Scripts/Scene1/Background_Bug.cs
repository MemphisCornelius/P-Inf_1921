using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Bug : MonoBehaviour
{
    
    public GameObject player;
    
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 temp = new Vector3(this.transform.position.x,this.transform.position.y,-1);
        Vector3 temp2 = new Vector3(this.transform.position.x,this.transform.position.y, 0);




        float yPlayer =player.transform.position.y;
        yPlayer = yPlayer+100;
        float yChair = this.transform.position.y;
        yChair = yChair+100; 
        
        if (yPlayer>yChair)
        {
            this.transform.position =temp;


        } else if(yPlayer<yChair){

            this.transform.position = temp2;
        }

    }
}

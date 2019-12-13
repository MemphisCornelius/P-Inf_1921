using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numpad : MonoBehaviour
{
    public Text text, Schlüsselnachricht;
    public int code = 6631;
    public bool geil = false, codebool = false;
    public float keymessagetimer, maxdis;
    public GameObject numbpad, activator, player;
    void Start()
    {
        Schlüsselnachricht.enabled=(false);
    }


    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(activator.transform.position, player.transform.position);
        if (Input.GetKeyDown("e") && dist < maxdis)
        {
            numbpad.SetActive(true);
        }
        else if (dist > maxdis)
        {
            numbpad.SetActive(false);
        }
        if (text.text == code.ToString())
        {
            geil = true;
            codebool = true;
            numbpad.SetActive(false);
            Schlüsselnachricht.enabled=true;
        }
        else if (text.text.Length >= code.ToString().Length)
        {
            text.text = "";
        }
        if (keymessagetimer >= 0 && codebool)
        { 
                keymessagetimer = keymessagetimer - Time.deltaTime;
            
        }
        if (keymessagetimer < 0) {

            Schlüsselnachricht.enabled = false;

        }
    }
        public void TaskOnClick1()
        {
            text.text = text.text + "1";
        }
        public void TaskOnClick2()
        {
            text.text = text.text + "2";
        }
        public void TaskOnClick3()
        {
            text.text = text.text + "3";
        }
        public void TaskOnClick4()
        {
            text.text = text.text + "4";
        }
        public void TaskOnClick5()
        {
            text.text = text.text + "5";
        }
        public void TaskOnClick6()
        {
            text.text = text.text + "6";
        }
        public void TaskOnClick7()
        {
            text.text = text.text + "7";
        }
        public void TaskOnClick8()
        {
            text.text = text.text + "8";
        }
        public void TaskOnClick9()
        {
            text.text = text.text + "9";
        }
     
}
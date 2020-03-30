using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class numpad : MonoBehaviour {
    public TextMeshProUGUI text;
    public Text Schlüsselnachricht;
    public int code = 6631;
    public bool geil = false, codebool = false;
    public float keymessagetimer, maxdis;
    public GameObject numbpad, activator, player, information_panel;

    void Start() {
        Schlüsselnachricht.enabled = (false);
    }


    // Update is called once per frame
    void Update() {
        float dist = Vector3.Distance(activator.transform.position, player.transform.position);
        if (Input.GetKeyDown("e") && dist < maxdis) {
            numbpad.SetActive(true);
        }
        else if (dist > maxdis) {
            numbpad.SetActive(false);
        }

        if (numbpad.active)
        {
            if(Input.GetKeyDown(KeyCode.Alpha0)) {TaskOnClick(0);}
            if(Input.GetKeyDown(KeyCode.Alpha1)) {TaskOnClick(1);}
            if(Input.GetKeyDown(KeyCode.Alpha2)) {TaskOnClick(2);}
            if(Input.GetKeyDown(KeyCode.Alpha3)) {TaskOnClick(3);}
            if(Input.GetKeyDown(KeyCode.Alpha4)) {TaskOnClick(4);}
            if(Input.GetKeyDown(KeyCode.Alpha5)) {TaskOnClick(5);}
            if(Input.GetKeyDown(KeyCode.Alpha6)) {TaskOnClick(6);}
            if(Input.GetKeyDown(KeyCode.Alpha7)) {TaskOnClick(7);}
            if(Input.GetKeyDown(KeyCode.Alpha8)) {TaskOnClick(8);}
            if(Input.GetKeyDown(KeyCode.Alpha9)) {TaskOnClick(9);}
            if (Input.GetKeyDown(KeyCode.Delete)) {TaskOnClickDelete();}

        }

        if (text.text == code.ToString()) {
            geil = true;
            codebool = true;
            numbpad.SetActive(false);
            Schlüsselnachricht.enabled = true;
            information_panel.SetActive(true);
        }
        else if (text.text.Length >= code.ToString().Length) {
            text.text = "";
        }

        if (keymessagetimer >= 0 && codebool) {
            keymessagetimer = keymessagetimer - Time.deltaTime;
        }

        if (keymessagetimer < 0) {
            Schlüsselnachricht.enabled = false;
            information_panel.SetActive(false);
        }
    }

    public void TaskOnClick(int i) {
        text.text += i;
    }

    public void TaskOnClickDelete() {
        if (text.text.Length > 0)
            text.text = text.text.Substring(0, text.text.Length - 1);
    }
}
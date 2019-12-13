using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Kreuzwortraetsel : MonoBehaviour
{
    public GameObject inputField1, inputField2, inputField3, inputField4, inputField5, inputField6, inputField7, Raetsel1;
    Transform[] children1;
    char[] glucose = new char[7];
    int length;
    char clear = ' ';

    // Update is called once per frame
    void Update()
    {

    }

    public void Raetsel1Laden()
    {
        Transform[] children1 = new Transform[Raetsel1.transform.childCount];
        for (int i = 0; i < Raetsel1.transform.childCount; i++)
        {
            children1[i] = Raetsel1.transform.GetChild(i).GetChild(0);
        }
        for (int i = 0; i < 7; i++)
        {
            Debug.Log(children1[i].name);
        }
        for (int i = 0; i < 7; i++)
        {
            Debug.Log(glucose[i]);
        }
        for (int i = 0; i < children1.Length; i++)
        {
            char[] array = inputField1.GetComponent<InputField>().text.ToCharArray();
            children1[i].GetComponent<Text>().text = array[i].ToString();
        }
    }
}
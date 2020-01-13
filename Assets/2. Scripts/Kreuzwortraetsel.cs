using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Kreuzwortraetsel : MonoBehaviour
{
    public GameObject inputField1, inputField2, inputField3, inputField4, inputField5, inputField6, inputField7, Raetsel1, Raetsel2, Raetsel3, Raetsel4, Raetsel5, Raetsel6, Raetsel7, tisch, player, kreutzwortraetsel, pflanze;
    char[] glucose = new char[7];
    char[] licht = new char[5];
    int length;
    public float radius;

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(tisch.transform.position, player.transform.position);
        if (Input.GetKeyDown("e") && dist < radius && player.GetComponent<PlayerMovement>().Movementenabled)
        {
            kreutzwortraetsel.SetActive(true);
            player.GetComponent<PlayerMovement>().Movementenabled = false;
            pflanze.GetComponent<SpriteRenderer>().color = new Vector4(0, 1, 0, 1);

        }
        else if (Input.GetKeyDown(KeyCode.Escape) && dist < radius && !player.GetComponent<PlayerMovement>().Movementenabled)
        {
            kreutzwortraetsel.SetActive(false);
            player.GetComponent<PlayerMovement>().Movementenabled = true;
        }
    }

    public void Raetsel1Laden()
    {
        Transform[] children = new Transform[Raetsel1.transform.childCount];
        for (int i = 0; i < Raetsel1.transform.childCount; i++)
        {
            children[i] = Raetsel1.transform.GetChild(i).GetChild(0);
        }
        for (int i = 0; i < children.Length; i++)
        {
            char[] array = inputField1.GetComponent<InputField>().text.ToCharArray();
            if (i < array.Length)
            {
                children[i].GetComponent<Text>().text = array[i].ToString();
                Debug.Log(array[i].ToString());
            }
        }
    }
    public void Raetsel2Laden()
    {
        Transform[] children = new Transform[Raetsel2.transform.childCount];
        for (int i = 0; i < Raetsel2.transform.childCount; i++)
        {
            children[i] = Raetsel2.transform.GetChild(i).GetChild(0);
        }
        for (int i = 0; i < children.Length; i++)
        {
            char[] array = inputField2.GetComponent<InputField>().text.ToCharArray();
            if (i < array.Length)
            {
                children[i].GetComponent<Text>().text = array[i].ToString();
                Debug.Log(array[i].ToString());
            }
        }
    }
    public void Raetsel3Laden()
    {
        Transform[] children = new Transform[Raetsel3.transform.childCount];
        for (int i = 0; i < Raetsel3.transform.childCount; i++)
        {
            children[i] = Raetsel3.transform.GetChild(i).GetChild(0);
        }
        for (int i = 0; i < children.Length; i++)
        {
            char[] array = inputField3.GetComponent<InputField>().text.ToCharArray();
            if (i < array.Length)
            {
                children[i].GetComponent<Text>().text = array[i].ToString();
                Debug.Log(array[i].ToString());
            }
        }
    }
    public void Raetsel4Laden()
    {
        Transform[] children = new Transform[Raetsel4.transform.childCount];
        for (int i = 0; i < Raetsel4.transform.childCount; i++)
        {
            children[i] = Raetsel4.transform.GetChild(i).GetChild(0);
        }
        for (int i = 0; i < children.Length; i++)
        {
            char[] array = inputField4.GetComponent<InputField>().text.ToCharArray();
            if (i < array.Length)
            {
                children[i].GetComponent<Text>().text = array[i].ToString();
                Debug.Log(array[i].ToString());
            }
        }
    }
    public void Raetsel5Laden()
    {
        Transform[] children = new Transform[Raetsel5.transform.childCount];
        for (int i = 0; i < Raetsel5.transform.childCount; i++)
        {
            children[i] = Raetsel5.transform.GetChild(i).GetChild(0);
        }
        for (int i = 0; i < children.Length; i++)
        {
            char[] array = inputField5.GetComponent<InputField>().text.ToCharArray();
            if (i < array.Length)
            {
                children[i].GetComponent<Text>().text = array[i].ToString();
                Debug.Log(array[i].ToString());
            }
        }
    }
    public void Raetsel6Laden()
    {
        Transform[] children = new Transform[Raetsel6.transform.childCount];
        for (int i = 0; i < Raetsel6.transform.childCount; i++)
        {
            children[i] = Raetsel6.transform.GetChild(i).GetChild(0);
        }
        for (int i = 0; i < children.Length; i++)
        {
            char[] array = inputField6.GetComponent<InputField>().text.ToCharArray();
            if (i < array.Length)
            {
                children[i].GetComponent<Text>().text = array[i].ToString();
                Debug.Log(array[i].ToString());
            }
        }
    }
    public void Raetsel7Laden()
    {
        Transform[] children = new Transform[Raetsel7.transform.childCount];
        for (int i = 0; i < Raetsel7.transform.childCount; i++)
        {
            children[i] = Raetsel7.transform.GetChild(i).GetChild(0);
        }
        for (int i = 0; i < children.Length; i++)
        {
            char[] array = inputField7.GetComponent<InputField>().text.ToCharArray();
            if (i < array.Length)
            {
                children[i].GetComponent<Text>().text = array[i].ToString();
                Debug.Log(array[i].ToString());
            }
        }
    }
}
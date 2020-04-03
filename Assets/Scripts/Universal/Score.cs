using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int[] Integer;
    public string[] String;
    public float[] Float;
   

    public void Save()
    {
        for (int i = 0; i < Integer.Length; i++) PlayerPrefs.SetInt("Int" + i, Integer[i]);
        for (int i = 0; i < String.Length; i++) PlayerPrefs.SetString("String" + i, String[i]);
        for (int i = 0; i < Float.Length; i++) PlayerPrefs.SetFloat("Float" + i, Float[i]);
    }

    public void Load()
    {
        for (int i = 0; i < Integer.Length; i++) Integer[i] = PlayerPrefs.GetInt("Int" + i, 0);
        for (int i = 0; i < String.Length; i++) String[i] = PlayerPrefs.GetString("String" + i, "");
        for (int i = 0; i < Float.Length; i++) Float[i] = PlayerPrefs.GetFloat("Float" + i, 0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WritingMovement : MonoBehaviour
{
    //Zeit zum Erscheinen
    public float letterPaused = 0.01f;
    //Nachricht
    public string message;
    //Textcomponente
    public Text textComp;

    // Use this for initialization
    void Start()
    {
        textComp = GetComponent<Text>();
         message = textComp.text;
        textComp.text = "";
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
       
        foreach (char letter in message.ToCharArray())
        {
            textComp.text += letter;
            yield return 0;
            yield return new WaitForSeconds(letterPaused);
        }
    }

}

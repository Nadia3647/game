using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeButtonText : MonoBehaviour
{
    public  TMP_Text buttonText;
    public Button btn; 
    void Start()
    {
        NewText();
    }

    public  void NewText()
    {

        if (ChangeScene.chek == 1)
        {
            buttonText.text = "Продолжить";
            btn.gameObject.SetActive(true);
        }
        
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class EnterName : MonoBehaviour
{
    public TextAsset inkJSONAsset;
    private Story story;
    public InputField inputField;
    public static string charaterName;
    public static int check;
    public Text myText;

    public void SaveInputText()
    {
        charaterName = myText.text.ToString();
    }
    public void ShowText()
    {
        story = new Story(inkJSONAsset.text);
        Debug.Log(charaterName);
        Debug.Log(story.variablesState["mainName"]);
        story.variablesState["mainName"] = charaterName;
        Debug.Log(story.variablesState["mainName"]);
        while (story.canContinue)
        {
            Debug.Log(story.Continue());
        }
        Debug.Log(check);

    }
    public void CheckVal()
    {
        check = 1;
    }
}